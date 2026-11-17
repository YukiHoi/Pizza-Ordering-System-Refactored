using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using FoodDeliverySYS.Business;
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS.DataAccess
{
    public class OracleOrderStore : IOrderStore
    {    
        public int SaveOrder(
            int customerId,
            List<PizzaCart> items,
            int paymentMethodId)
        {
            decimal total = items.Sum(item => item.Price);

            OracleConnection conn =
                new OracleConnection(DBConnect.oraDB);

            conn.Open();

            // Create and save the order.
            String sqlQuery =
                "SELECT CUSTOMER_ORDER_SEQ.NEXTVAL FROM dual";

            int orderId = getNextId(conn, sqlQuery);

            CustomerOrders order = new CustomerOrders(
                orderId,
                DateTime.Now,
                total,
                customerId,
                'Y',
                "Processing");

            addCustomerOrder(conn, order);

            // Save each pizza item.
            foreach (PizzaCart item in items)
            {
                sqlQuery =
                    "SELECT ORDER_DETAIL_SEQ.NEXTVAL FROM dual";

                int detailId = getNextId(conn, sqlQuery);

                addOrderDetails(conn, detailId, orderId, item);
            }

            // Save the payment.
            sqlQuery =
                "SELECT PAYMENT_SEQ.NEXTVAL FROM dual";

            int paymentId = getNextId(conn, sqlQuery);

            addPayment(
                conn, paymentId, orderId, total, paymentMethodId);

            conn.Close();
            conn.Dispose();

            return orderId;
        }

        private void addCustomerOrder(
            OracleConnection conn,
            CustomerOrders order)
        {
            String sqlQuery =
                "INSERT INTO CustomerOrders " +
                "(order_id, order_date, total_price, customer_id, " +
                "payment_status, order_status) VALUES (" +
                order.getOrder_id() + ", " +
                "TO_DATE('" +
                order.getOrder_date().ToString("yyyy-MM-dd") +
                "', 'YYYY-MM-DD'), " +
                order.getTotal_price().ToString(
                    CultureInfo.InvariantCulture) + ", " +
                order.getCustomer_id() + ", '" +
                order.getPayment_status() + "', '" +
                order.getOrder_status() + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        private void addOrderDetails(
            OracleConnection conn,
            int detailId,
            int orderId,
            PizzaCart item)
        {
            String sqlQuery =
                "INSERT INTO OrderDetails " +
                "(order_detail_id, order_id, pizza_id, crust_id, " +
                "size_id, quantity, line_total_price) VALUES (" +
                detailId + ", " +
                orderId + ", " +
                item.PizzaId + ", " +
                item.CrustId + ", " +
                item.SizeId + ", " +
                item.Quantity + ", " +
                item.Price.ToString(CultureInfo.InvariantCulture) + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        private void addPayment(
            OracleConnection conn,
            int paymentId,
            int orderId,
            decimal total,
            int paymentMethodId)
        {
            String sqlQuery =
                "INSERT INTO Payment " +
                "(payment_id, order_id, payment_amount, " +
                "payment_method_id) VALUES (" +
                paymentId + ", " +
                orderId + ", " +
                total.ToString(CultureInfo.InvariantCulture) + ", " +
                paymentMethodId + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        private int getNextId(
            OracleConnection conn,
            String sqlQuery)
        {
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            int nextId = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Dispose();

            return nextId;
        }
    }
}