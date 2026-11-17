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
        "payment_status, order_status) " +
        "VALUES (:orderId, :orderDate, :totalPrice, " +
        ":customerId, :paymentStatus, :orderStatus)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;

            OracleParameter orderId =
                new OracleParameter("orderId", OracleDbType.Int32);
            orderId.Value = order.getOrder_id();
            cmd.Parameters.Add(orderId);

            OracleParameter orderDate =
                new OracleParameter("orderDate", OracleDbType.Date);
            orderDate.Value = order.getOrder_date();
            cmd.Parameters.Add(orderDate);

            OracleParameter totalPrice =
                new OracleParameter("totalPrice", OracleDbType.Decimal);
            totalPrice.Value = order.getTotal_price();
            cmd.Parameters.Add(totalPrice);

            OracleParameter customerId =
                new OracleParameter("customerId", OracleDbType.Int32);
            customerId.Value = order.getCustomer_id();
            cmd.Parameters.Add(customerId);

            OracleParameter paymentStatus =
                new OracleParameter("paymentStatus", OracleDbType.Varchar2);
            paymentStatus.Value = order.getPayment_status().ToString();
            cmd.Parameters.Add(paymentStatus);

            OracleParameter orderStatus =
                new OracleParameter("orderStatus", OracleDbType.Varchar2);
            orderStatus.Value = order.getOrder_status();
            cmd.Parameters.Add(orderStatus);

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