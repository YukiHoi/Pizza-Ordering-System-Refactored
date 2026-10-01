using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS
{
    internal class PaymentMethod
    {
        private int payment_method_id;
        private string method_name;

        public PaymentMethod()
        {
            this.payment_method_id = 0;
            this.method_name = "";
        }
        public PaymentMethod(int payment_method_id, string method_name)
        {
            this.payment_method_id = payment_method_id;
            this.method_name = method_name;
        }
        public int getPayment_method_id() { return this.payment_method_id; }
        public String getMethod_name() { return this.method_name; }
        public void setPayment_method_id(int payment_method_id) { this.payment_method_id = payment_method_id; }
        public void setMethod_name(string method_name) { this.method_name = method_name; }

        public static DataSet getAllPaymentMethod()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            String sqlQuery = "SELECT payment_method_id, method_name FROM PaymentMethod ORDER BY payment_method_id";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
           
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "PaymentMethod");

            conn.Close();

            return ds;

        }
    }
}
