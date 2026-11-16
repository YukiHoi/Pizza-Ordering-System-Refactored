using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliverySYS.Business;
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS.DataAccess
{
    public class OracleDeliveryStore : IDeliveryStore
    {
        public void DispatchOrder(
            int deliveryId, int orderId,
            int staffId, DateTime deliveryDate)
        {
            using (var connection = new OracleConnection(DBConnect.oraDB))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Update only a processing order.
                        int updated = Execute(connection, transaction,
                            @"UPDATE CustomerOrders
                              SET order_status = 'Dispatched'
                              WHERE order_id = :orderId
                              AND order_status = 'Processing'",
                            new OracleParameter("orderId", orderId));

                        if (updated != 1)
                            throw new InvalidOperationException(
                                "The order is not available for dispatch.");

                        // Save the driver assignment in the same transaction.
                        Execute(connection, transaction,
                            @"INSERT INTO Delivery
                              (delivery_id, delivery_date, staff_id, order_id)
                              VALUES (:id, :deliveryDate, :staffId, :orderId)",
                            new OracleParameter("id", deliveryId),
                            new OracleParameter("deliveryDate", OracleDbType.Date)
                            {
                                Value = deliveryDate
                            },
                            new OracleParameter("staffId", staffId),
                            new OracleParameter("orderId", orderId));

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void CloseDelivery(int orderId)
        {
            using (var connection = new OracleConnection(DBConnect.oraDB))
            {
                connection.Open();

                int updated = Execute(connection, null,
                    @"UPDATE CustomerOrders
                      SET order_status = 'Delivered'
                      WHERE order_id = :orderId
                      AND order_status = 'Dispatched'",
                    new OracleParameter("orderId", orderId));

                if (updated != 1)
                    throw new InvalidOperationException(
                        "Only a dispatched order can be marked as delivered.");
            }
        }

        // Set up and run a database command.
        private static int Execute(
            OracleConnection connection,
            OracleTransaction transaction,
            string sql,
            params OracleParameter[] parameters)
        {
            using (var command = new OracleCommand(sql, connection))
            {
                if (transaction != null)
                    command.Transaction = transaction;

                command.BindByName = true;
                command.Parameters.AddRange(parameters);
                return command.ExecuteNonQuery();
            }
        }
    }
}

  

