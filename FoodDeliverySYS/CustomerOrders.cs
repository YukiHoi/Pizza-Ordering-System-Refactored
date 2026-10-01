using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS
{
    internal class CustomerOrders
    {
        private int order_id;
        private DateTime order_date;
        private decimal total_price;
        private int customer_id;
        private Char payment_status;
        private string order_status;

        public CustomerOrders()
        {
            this.order_id = 0;
            this.order_date = DateTime.Now;
            this.total_price = 0;
            this.customer_id = 0;
            this.payment_status = 'N';
            this.order_status = "Pending";
        }
        public CustomerOrders(int order_id, DateTime order_date, decimal total_price, int customer_id, char payment_status, string order_status)
        {
            this.order_id = order_id;
            this.order_date = order_date;
            this.total_price = total_price; 
            this.customer_id = customer_id;
            this.payment_status = payment_status;
            this.order_status = order_status;
        }

        public int getOrder_id() { return this.order_id; }
        public DateTime getOrder_date() { return this.order_date; }
        public decimal getTotal_price() { return this.total_price; }
        public int getCustomer_id() { return this.customer_id; }
        public Char getPayment_status() { return this.payment_status; }
        public string getOrder_status() { return this.order_status; }
        public void setOrder_id(int order_id) { this.order_id = order_id; }
        public void setOrder_date(DateTime order_date) { this.order_date = order_date; }
        public void setTotal_price(decimal total_price) { this.total_price = total_price; }
        public void setCustomer_id(int customer_id) { this.customer_id = customer_id; }
        public void setPayment_status(Char payment_status) { this.payment_status = payment_status; }
        public void setOrder_status(string order_status) { this.order_status = order_status; }

     
        public void addCustomerOrder()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "INSERT INTO CustomerOrders (order_id, order_date, total_price, customer_id, payment_status,order_status) VALUES (" +
                this.order_id + ", " +
                "TO_DATE('" + this.order_date.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD'), " +
                this.total_price + ", " +
                this.customer_id + ", '" +  
                this.payment_status + "', '" +
                this.order_status + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
        public void getCustomerOrder(int order_id) //This method will get the customer details from the database
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT * FROM CustomerOrders WHERE order_id = " + order_id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();  //read data from the reader


            setOrder_id(dr.GetInt32(0));
            setOrder_date(dr.GetDateTime(1));
            setTotal_price(dr.GetDecimal(2));
            setCustomer_id(dr.GetInt32(3));
            setPayment_status(dr.GetString(4)[0]);
            setOrder_status(dr.GetString(5));

            conn.Close();
        }

        public static DataSet findOrderId(int order_id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();
            string sqlQuery = "SELECT order_id, order_date, total_price, customer_id, payment_status, order_status " +
                   "FROM CustomerOrders " +
                   "WHERE order_id =" + order_id+
                   "ORDER BY order_id";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "CustomerOrders");

            return ds;
        }
        public static DataSet getAllOrdersByDate(DateTime order_date)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();
            string sqlQuery = "SELECT * FROM CustomerOrders WHERE order_date = TO_DATE('" + order_date.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD')";


            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "CustomerOrders");

            return ds;
        }


        public static int getNextOrderID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT MAX(order_id) FROM CustomerOrders";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
             conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            conn.Close();

            return nextId;
        }
        public void updateOrderStatusToDispatched()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "UPDATE CustomerOrders " +
                              "SET order_status = 'Dispatched'" +
                              "WHERE order_id = " + this.order_id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void updateOrderStatusToDelivered()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "UPDATE CustomerOrders " +
                              "SET order_status = 'Delivered'" +
                              "WHERE order_id = " + this.order_id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public static int getOrderIdByCustomerId(string currentCustomer_id)//This method will get the order id by customer id
        {
            int currentOrderID = 0;
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string sqlQuery = "SELECT order_id FROM CustomerOrders WHERE customer_id = '" + currentCustomer_id + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                currentOrderID = dr.GetInt32(0);
            }

            conn.Close();

            return currentOrderID;

        }
        public static DataSet getAllOrdersPerOneCustomer(int currentCustomer_id)//This method will get all orders per customer in view order history form
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string sqlQuery = "SELECT co.order_id, " +
                "p.pizza_name, " +
                "c.crust_type, " +
                "s.pizza_size, " +
                "co.order_date, " +
                "co.total_price, " +
                "co.payment_status, " +
                "co.order_status " +
                "FROM CustomerOrders co " +
                "JOIN OrderDetails od ON co.order_id = od.order_id " +
                "JOIN Pizza p ON od.pizza_id = p.pizza_id " +
                "JOIN CrustType c ON od.crust_id = c.crust_id " +
                "JOIN PizzaSize s ON od.size_id = s.size_id " +
                "WHERE co.customer_id = " + currentCustomer_id +
                "ORDER BY co.order_id DESC";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "CustomerOrders");

            // Close db connection
            conn.Close();

            return ds;
        }
        public static DataSet getOrdersReadyForDispatch() //This method will get all orders ready for dispatch
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string sqlQuery = "SELECT order_id FROM CustomerOrders " +
                "WHERE payment_status = 'Y' AND order_status NOT IN ('Dispatched', 'Delivered') " +
                "ORDER BY order_id";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "CustomerOrders");

            // Close db connection
            conn.Close();

            return ds;
        }
        public static DataSet getOrdersReadyForCloseDelivery() //This method will get all orders ready for close delivery
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string sqlQuery = "SELECT order_id FROM CustomerOrders " +
                "WHERE payment_status = 'Y' AND order_status NOT IN ('Processing', 'Delivered') " +
                "ORDER BY order_id";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "CustomerOrders");

            // Close db connection
            conn.Close();

            return ds;
        }

    }
}

