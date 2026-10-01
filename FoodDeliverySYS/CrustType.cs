using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS
{
    internal class CrustType
    {
        private int crust_id;
        private string crust_type;
        private decimal crust_price;

        public CrustType()
        {
            this.crust_id = 0;
            this.crust_type = "";
            this.crust_price = 0;
        }
        public CrustType(int crust_id, string crust_type, decimal crust_price)
        {
            this.crust_id = crust_id;
            this.crust_type = crust_type;
            this.crust_price = crust_price;
        }
        public int getCrust_id() { return this.crust_id; }
        public String getCrust_type() { return this.crust_type; }
        public decimal getCrust_price() { return this.crust_price; }

        public void setCrust_id(int crust_id) { this.crust_id = crust_id; }
        public void setCrust_type(string crust_type) { this.crust_type = crust_type; }
        public void setCrust_price(decimal crust_price) { this.crust_price = crust_price; }

        public static DataSet getAllCrustType()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT * FROM CrustType ORDER BY crust_id";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "CrustType");

            // Close db connection
            conn.Close();

            return ds;
        }
    }
    }

