using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS
{
    internal class Category
    {
        private int category_id;
        private string category_name;

        public Category()
        {
            this.category_id = 0;
            this.category_name = "";
        }
        public Category(int category_id, string category_name)
        {
            this.category_id = category_id;
            this.category_name = category_name;
        }
        public int getCategory_id() { return this.category_id; }
        public String getCategory_name() { return this.category_name; }

        public void setCategory_id(int category_id)
        {
            this.category_id = category_id;
        }
        public void setCategory_name(string category_name)
        {
            this.category_name = category_name;
        }
        public static DataSet getAllCategory()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT category_id, category_name" +
                " FROM Category ORDER BY category_id";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Category");

            //Close db connection
            conn.Close();

            return ds;

        }
      
    }
}
