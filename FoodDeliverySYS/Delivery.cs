using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS
{
    internal class Delivery
    {
        private int delivery_id;
        private int order_id;
        private int staff_id;
        private DateTime delivery_date;

        public Delivery()
        {
            this.delivery_id = 0;
            this.order_id = 0;
            this.staff_id = 0;
            this.delivery_date = DateTime.Today;         
            
        }
        public Delivery(int delivery_id, DateTime delivery_date, int staff_id, int order_id)
        {
            this.delivery_id = delivery_id;
            this.delivery_date = delivery_date;
            this.staff_id = staff_id;
            this.order_id = order_id;
               
        }

        public static int getNextDeliveryID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT MAX(delivery_id) FROM Delivery";

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
        public void addDelivery()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "INSERT INTO Delivery VALUES(" +
                 this.delivery_id + ", " +
                 "TO_DATE('" + this.delivery_date.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD'), " +  // https://stackoverflow.com/questions/698339/how-to-insert-date-in-an-oracle-relational-database-using-c-sharp
                 this.staff_id + ", " +
                 this.order_id + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
