using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS
{
    internal class Payment
    {
        private int payment_id;
        private int order_id;
        private decimal payment_amount;
        private int payment_method_id;

        public Payment()
        {
            this.payment_id = 0;
            this.order_id = 0;
            this.payment_amount = 0;
            this.payment_method_id = 0;
        }
        public Payment(int payment_id, int order_id, decimal payment_amount, int payment_method_id)
        {
            this.payment_id = payment_id;
            this.order_id = order_id;
            this.payment_amount = payment_amount;
            this.payment_method_id = payment_method_id;
        }
        public int getPayment_id() { return this.payment_id; }
        public int getOrder_id() { return this.order_id; }
        public decimal getPayment_amount() { return this.payment_amount; }
        public int getPayment_method_id() { return this.payment_method_id; }
        public void setPayment_id(int payment_id) { this.payment_id = payment_id; }
        public void setOrder_id(int order_id) { this.order_id = order_id; }
        public void setPayment_amount(decimal payment_amount) { this.payment_amount = payment_amount; }
        public void setPayment_method_id(int payment_method_id) { this.payment_method_id = payment_method_id; }

  
        public void addPayment()
        { 
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);


            string sqlQuery = "INSERT INTO Payment VALUES (" +
                this.payment_id + "," +
                this.order_id + "," +
                this.payment_amount + ",'" +
                this.payment_method_id + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public static int getNextPayment_id()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT MAX(Payment_id) FROM Payment";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            int nextPaymentId;
            dr.Read();

            if (dr.IsDBNull(0)) //if the result is null, then the next pizza id is 1
                nextPaymentId = 1;
            else
            {
                nextPaymentId = dr.GetInt32(0) + 1; //if the result is not null, then the next pizza id is the max pizza id + 1
            }

            conn.Close();

            return nextPaymentId; 
        }
    }
}
