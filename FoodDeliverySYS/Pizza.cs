using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FoodDeliverySYS
{
    internal class Pizza
    {
        public int pizza_id;
        public string pizza_name;
        public string description;
        public int category_id;
        public decimal base_price;

        public Pizza()
        {
            this.pizza_id = 0;
            this.pizza_name = "";
            this.description = "";
            this.category_id = 0;
            this.base_price = 0;

        }
        public Pizza(int pizza_id, string pizza_name, string description, int category_id,
           decimal base_price)
        {
            this.pizza_id = pizza_id;
            this.pizza_name = pizza_name;
            this.description = description;
            this.category_id = category_id;
            this.base_price = base_price;

        }
        public int getPizza_id() { return this.pizza_id; }
        public String getPizza_name() { return this.pizza_name; }
        public String getDescription() { return this.description; }
        public int getCategory_id() { return this.category_id; }
        public decimal getBase_price() { return this.base_price; }

        public void setPizza_id(int pizza_id) { this.pizza_id = pizza_id; }
        public void setPizza_name(string pizza_name) { this.pizza_name = pizza_name; }
        public void setDescription(string description) { this.description = description; }
        public void setCategory_id(int category_id) { this.category_id = category_id; }
        public void setBase_price(decimal base_price) { this.base_price = base_price; }
     
        public static DataSet getAllPizza()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT p.pizza_id, p.pizza_name, p.description, c.Category_name AS Category, p.base_price" +
                " FROM Pizza p JOIN Category c ON p.category_id = c.category_id " +
                "WHERE p.pizza_name NOT IN ('Nonavailable') " +
                "ORDER BY p.pizza_id";


            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();//
            da.Fill(ds, "Pizza");

            //Close db connection
            conn.Close();

            return ds;

        }
 
        public void getPizza(int pizza_id) //This method will get the pizza details from the database
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT * FROM Pizza WHERE pizza_id = " + pizza_id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();  //read data from the reader


            setPizza_id(dr.GetInt32(0)); //get the pizza id from the database
            setPizza_name(dr.GetString(1)); //get the pizza name from the database
            setDescription(dr.GetString(2)); //get the description from the database
            setCategory_id(dr.GetInt32(3)); //get the category id from the database
            setBase_price(dr.GetDecimal(4)); //get the base price from the database


            //close DB
            conn.Close();
        }
        public void addPizza() //This method will add the pizza details to the database
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);


            string sqlQuery = "INSERT INTO Pizza (pizza_id, pizza_name, description, category_id, base_price) " +
                "VALUES (" +
                this.pizza_id + ",'" +
                this.pizza_name + "','" +
                this.description + "'," +
                this.category_id + "," +
                this.base_price + ")";


            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public static DataSet findPizza(String pizza_name) //This method for staff find the pizza details from the database by entering the pizza name
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();
            string sqlQuery = "SELECT pizza_id, pizza_name, description, category_id, base_price " +
                  "FROM Pizza " +
                  "WHERE LOWER(Pizza_name) LIKE LOWER('%" + pizza_name + "%')" +
                  "ORDER BY pizza_name";


            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Pizza");

            return ds;


        }
        public void removePizza() //This method to remove pizza but not really remove, only update to Nonavailable
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string sqlQuery = "UPDATE Pizza SET " +
                     "Pizza_name = 'Nonavailable', " +
                     "description = 'None', " +
                     "category_id = " + this.category_id + ", " +
                     "base_price = '0' " +
                     "WHERE pizza_id = " + this.pizza_id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public static int getNextPizza_id()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT MAX(Pizza_id) FROM Pizza";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Declare a variable to store the next pizza id
            int nextPizzaId;
            dr.Read();

            if (dr.IsDBNull(0)) //if the result is null, then the next pizza id is 1
                nextPizzaId = 1;
            else
            {
                nextPizzaId = dr.GetInt32(0) + 1; //if the result is not null, then the next pizza id is the max pizza id + 1
            }

            //Close db connection
            conn.Close();

            return nextPizzaId; 
        }
        public static bool checkPizzaExists(string pizza_name)
        {
            bool exists = false; 

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string sqlQuery = "SELECT pizza_name FROM Pizza WHERE LOWER(pizza_name) LIKE LOWER('%"  + pizza_name + "%')";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            exists = cmd.ExecuteScalar() != null;
            conn.Close();
            return exists;
        }
    }
}
