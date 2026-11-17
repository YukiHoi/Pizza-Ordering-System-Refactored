using System;
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
            OracleConnection conn =
                new OracleConnection(DBConnect.oraDB);

            conn.Open();

            addDelivery(
                conn, deliveryId, deliveryDate, staffId, orderId);

            updateOrderStatusToDispatched(conn, orderId);

            conn.Close();
        }

        private void addDelivery(
            OracleConnection conn,
            int delivery_id,
            DateTime delivery_date,
            int staff_id,
            int order_id)
        {
            String sqlQuery =
                "INSERT INTO Delivery " +
                "(delivery_id, delivery_date, staff_id, order_id) " +
                "VALUES (:deliveryId, :deliveryDate, :staffId, :orderId)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;

            cmd.Parameters.Add(
                new OracleParameter("deliveryId", delivery_id));

            OracleParameter dateParameter =
                new OracleParameter("deliveryDate", OracleDbType.Date);
            dateParameter.Value = delivery_date;
            cmd.Parameters.Add(dateParameter);

            cmd.Parameters.Add(
                new OracleParameter("staffId", staff_id));

            cmd.Parameters.Add(
                new OracleParameter("orderId", order_id));

            conn.Close();
        }

        private void updateOrderStatusToDispatched(
            OracleConnection conn, int order_id)
        {
            String sqlQuery = "UPDATE CustomerOrders " +
                              "SET order_status = 'Dispatched' " +
                              "WHERE order_id = :orderId";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;

            cmd.Parameters.Add(
                new OracleParameter("orderId", order_id));

            conn.Close();
        }

        public void CloseDelivery(int orderId)
        {
            OracleConnection conn =
                new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "UPDATE CustomerOrders " +
                              "SET order_status = 'Delivered' " +
                              "WHERE order_id = :orderId";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;

            cmd.Parameters.Add(
                new OracleParameter("orderId", orderId));

            conn.Open();
            conn.Close();
        }
    }
}