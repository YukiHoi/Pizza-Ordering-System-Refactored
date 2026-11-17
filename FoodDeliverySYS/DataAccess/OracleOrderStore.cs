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
                "size_id, quantity, line_total_price) " +
                "VALUES (:detailId, :orderId, :pizzaId, :crustId, " +
                ":sizeId, :quantity, :lineTotal)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;

            OracleParameter detailIdParameter =
                new OracleParameter("detailId", OracleDbType.Int32);
            detailIdParameter.Value = detailId;
            cmd.Parameters.Add(detailIdParameter);

            OracleParameter orderIdParameter =
                new OracleParameter("orderId", OracleDbType.Int32);
            orderIdParameter.Value = orderId;
            cmd.Parameters.Add(orderIdParameter);

            OracleParameter pizzaId =
                new OracleParameter("pizzaId", OracleDbType.Int32);
            pizzaId.Value = item.PizzaId;
            cmd.Parameters.Add(pizzaId);

            OracleParameter crustId =
                new OracleParameter("crustId", OracleDbType.Int32);
            crustId.Value = item.CrustId;
            cmd.Parameters.Add(crustId);

            OracleParameter sizeId =
                new OracleParameter("sizeId", OracleDbType.Int32);
            sizeId.Value = item.SizeId;
            cmd.Parameters.Add(sizeId);

            OracleParameter quantity =
                new OracleParameter("quantity", OracleDbType.Int32);
            quantity.Value = item.Quantity;
            cmd.Parameters.Add(quantity);

            OracleParameter lineTotal =
                new OracleParameter("lineTotal", OracleDbType.Decimal);
            lineTotal.Value = item.Price;
            cmd.Parameters.Add(lineTotal);

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
                "(payment_id, order_id, payment_amount, payment_method_id) " +
                "VALUES (:paymentId, :orderId, :amount, :methodId)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;

            OracleParameter paymentIdParameter =
                new OracleParameter("paymentId", OracleDbType.Int32);
            paymentIdParameter.Value = paymentId;
            cmd.Parameters.Add(paymentIdParameter);

            OracleParameter orderIdParameter =
                new OracleParameter("orderId", OracleDbType.Int32);
            orderIdParameter.Value = orderId;
            cmd.Parameters.Add(orderIdParameter);

            OracleParameter amount =
                new OracleParameter("amount", OracleDbType.Decimal);
            amount.Value = total;
            cmd.Parameters.Add(amount);

            OracleParameter methodId =
                new OracleParameter("methodId", OracleDbType.Int32);
            methodId.Value = paymentMethodId;
            cmd.Parameters.Add(methodId);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
    }
}