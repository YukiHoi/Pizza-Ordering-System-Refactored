using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS
{
    internal class PizzaSize
    {
        public int size_id;
        public string pizza_size;
        public decimal size_price;

        public PizzaSize()
        {
            this.size_id = 0;
            this.pizza_size = "";
            this.size_price = 0;
        }
        public PizzaSize(int size_id, string pizza_size, decimal size_price)
        {
            this.size_id = size_id;
            this.pizza_size = pizza_size;
            this.size_price = size_price;
        }
        public int getSize_id() { return this.size_id; }
        public String getPizza_size() { return this.pizza_size; }
        public decimal getSize_price() { return this.size_price; }

        public void setSize_id(int size_id) { this.size_id = size_id; }
        public void setPizza_size(string pizza_size) { this.pizza_size = pizza_size; }
        public void setSize_price(decimal size_price) { this.size_price = size_price; }

        public static DataSet getAllPizzaSize()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT *" +
                " FROM PizzaSize ORDER BY size_id";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "PizzaSize");

            //Close db connection
            conn.Close();

            return ds;

        }
    }
}
