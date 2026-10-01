using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS
{
    internal class OrderDetails
    {
        private int order_detail_id;
        private int order_id;
        private int pizza_id;
        private int crust_id;
        private int size_id;
        private int quantity;
        private decimal line_total_price;
        private int currentOrderId;
        private int currentCustomerId;
        private int orderId;
        private decimal totalPrice;

        public OrderDetails()
        {
            this.order_detail_id = 0;
            this.order_id = 0;
            this.pizza_id = 0;
            this.crust_id = 0;
            this.size_id = 0;
            this.quantity = 0;
            this.line_total_price = 0;

        }
        public OrderDetails(int order_detail_id, int order_id, int pizza_id, int crust_id, int size_id, int quantity, decimal line_total_price)
        {
            this.order_detail_id= order_detail_id;
            this.order_id=order_id;
            this.pizza_id= pizza_id;
            this.crust_id = crust_id;
            this.size_id = size_id;  
            this.quantity = quantity;
            this.line_total_price = line_total_price;

        }

        public OrderDetails(int currentOrderId, int currentCustomerId, int orderId, decimal totalPrice)
        {
            this.currentOrderId = currentOrderId;
            this.currentCustomerId = currentCustomerId;
            this.orderId = orderId;
            this.totalPrice = totalPrice;
        }

        public int getOrder_detail_id() { return this.order_detail_id; }
        public int getOrder_id() { return this.order_id; }
        public int getPizza_id() { return this.pizza_id; }
        public int getCrust_id() { return this.crust_id; }
        public int getSize_id() { return this.size_id; }
        public int getQuantity() { return this.quantity; }
        public decimal getLine_total_price() { return this.line_total_price; }
        public void setOrder_detail_id(int order_details_id) { this.order_detail_id = order_details_id; }
        public void setOrder_id(int order_id) { this.order_id = order_id; }
        public void setPizza_id(int pizza_id) { this.pizza_id = pizza_id; }
        public void setCrust_id(int crust_id) { this.crust_id = crust_id; }
        public void setSize_id(int size_id) { this.size_id = size_id; }
        public void setQuantity(int quantity) { this.quantity = quantity; }
        public void setLine_total_price(decimal line_total_price) { this.line_total_price = line_total_price; }

       
        public void addOrderDetails()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO OrderDetails (order_detail_id, order_id, pizza_id, crust_id, size_id, quantity, line_total_price) VALUES (" +
                this.order_detail_id + "," +
                this.order_id + "," +
                this.pizza_id + "," +
                this.crust_id + "," +
                this.size_id + "," +
                this.quantity + "," +
                this.line_total_price + ")";



            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
        public static int getNextOrderDetailId()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT MAX(order_detail_id) FROM OrderDetails";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Declare a variable to store the next pizza id
            int nextOrderDetailsId;
            dr.Read();

            if (dr.IsDBNull(0)) //if the result is null, then the next pizza id is 1
                nextOrderDetailsId = 1;
            else
            {
                nextOrderDetailsId = dr.GetInt32(0) + 1; //if the result is not null, then the next pizza id is the max pizza id + 1
            }

            //Close db connection
            conn.Close();

            return nextOrderDetailsId;
        }
        public static int getOrderDetailIdByCustomerId(string currentCustomer_id)//This method will get the order id by customer id
        {
            int currentOrderDetailId = 0;
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string sqlQuery = "SELECT * FROM OrderDetails WHERE order_id IN (" +
                "SELECT order_id FROM CustomerOrders WHERE customer_id =" + currentCustomer_id + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                currentOrderDetailId = dr.GetInt32(0);
            }

            conn.Close();

            return currentOrderDetailId;

        }

    }
}
