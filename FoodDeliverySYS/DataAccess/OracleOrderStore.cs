using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliverySYS.Business;
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS.DataAccess
{
    public class OracleOrderStore : IOrderStore
    {
        public int SaveOrder(
            int customerId,
            IReadOnlyList<PizzaCart> items,
            int paymentMethodId)
        {
            if (customerId <= 0 || paymentMethodId <= 0)
                throw new ArgumentException(
                    "A customer and payment method are required.");

            if (items == null || items.Count == 0)
                throw new ArgumentException("The cart is empty.");

            decimal total = items.Sum(item => item.Price);

            using (var connection =
                new OracleConnection(DBConnect.oraDB))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int orderId = GetNextId(
                            connection, transaction,
                            "SELECT CUSTOMER_ORDER_SEQ.NEXTVAL FROM dual");

                        // Save one order for the complete cart.
                        Execute(connection, transaction,
                            @"INSERT INTO CustomerOrders
                              (order_id, order_date, total_price,
                               customer_id, payment_status, order_status)
                              VALUES
                              (:orderId, :orderDate, :total,
                               :customerId, 'Y', 'Processing')",
                            new OracleParameter("orderId", orderId),
                            new OracleParameter("orderDate", OracleDbType.Date)
                            {
                                Value = DateTime.Now
                            },
                            new OracleParameter("total", total),
                            new OracleParameter("customerId", customerId));

                        // Save each cart item under the same order.
                        foreach (PizzaCart item in items)
                        {
                            int detailId = GetNextId(
                                connection, transaction,
                                "SELECT ORDER_DETAIL_SEQ.NEXTVAL FROM dual");

                            Execute(connection, transaction,
                                @"INSERT INTO OrderDetails
                                  (order_detail_id, order_id, pizza_id,
                                   crust_id, size_id, quantity,
                                   line_total_price)
                                  VALUES
                                  (:detailId, :orderId, :pizzaId,
                                   :crustId, :sizeId, :quantity,
                                   :lineTotal)",
                                new OracleParameter("detailId", detailId),
                                new OracleParameter("orderId", orderId),
                                new OracleParameter("pizzaId", item.PizzaId),
                                new OracleParameter("crustId", item.CrustId),
                                new OracleParameter("sizeId", item.SizeId),
                                new OracleParameter("quantity", item.Quantity),
                                new OracleParameter("lineTotal", item.Price));
                        }

                        int paymentId = GetNextId(
                            connection, transaction,
                            "SELECT PAYMENT_SEQ.NEXTVAL FROM dual");

                        // Record one simulated payment for the order.
                        Execute(connection, transaction,
                            @"INSERT INTO Payment
                              (payment_id, order_id,
                               payment_amount, payment_method_id)
                              VALUES
                              (:paymentId, :orderId,
                               :amount, :methodId)",
                            new OracleParameter("paymentId", paymentId),
                            new OracleParameter("orderId", orderId),
                            new OracleParameter("amount", total),
                            new OracleParameter("methodId", paymentMethodId));

                        // Keep all records only when every insert succeeds.
                        transaction.Commit();
                        return orderId;
                    }
                    catch
                    {
                        // Cancel the inserts if any part fails.
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        private static int GetNextId(
            OracleConnection connection,
            OracleTransaction transaction,
            string sql)
        {
            using (var command = new OracleCommand(sql, connection))
            {
                command.Transaction = transaction;
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        private static void Execute(
            OracleConnection connection,
            OracleTransaction transaction,
            string sql,
            params OracleParameter[] parameters)
        {
            using (var command = new OracleCommand(sql, connection))
            {
                command.Transaction = transaction;
                command.BindByName = true;
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
            }
        }
    }
}
