using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS
{
    internal class Staff
    {
        private int staff_id;
        private string first_name;
        private string last_name;
        private string role;
        private int phone_no;
        private string email;
        private decimal salary;
        private DateTime hire_date;
        private string password;

        public Staff()
        {
            this.staff_id = 0;
            this.first_name = "";
            this.last_name = "";
            this.role = "";
            this.email = "";
            this.phone_no = 0;
            this.salary = 0;
            this.hire_date = DateTime.Now;
            this.password = "";

        }

        public Staff(int staff_id, string first_name, string last_name, string role, int phone_no, 
            string email, decimal salary, DateTime hire_date, string password)
        {
            this.staff_id = staff_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.role = role;
            this.phone_no = phone_no;
            this.email = email;
            this.salary = salary;
            this.hire_date = hire_date;
            this.password = password;


        }
        public int getStaff_id() { return this.staff_id; }
        public String getFirst_name() { return this.first_name; }
        public String getLast_name() { return this.last_name; }
        public String getRole() { return this.role; }
        public int getPhone_no() { return this.phone_no; }
        public string getEmail() { return this.email; }
        public decimal getSalary() { return this.salary; }
        public DateTime getHire_date() { return this.hire_date; }
        public string getPassword() { return this.password; }

        public int setStaff_id(int staff_id) { return this.staff_id = staff_id; }
        public String setFirst_name(String first_name) { return this.first_name = first_name; }
        public String setLast_name(String last_name) { return this.last_name = last_name; }
        public String setRole(String role) { return this.role = role; }
        public int setPhone_no(int phone_no) { return this.phone_no = phone_no; }
        public string setEmail(string email) { return this.email = email; }
        public decimal setSalary(decimal salary) { return this.salary = salary; }
        public DateTime setHire_date(DateTime hire_date) { return this.hire_date = hire_date; }
        public string setPassword(string password) { return this.password = password; }

        public static DataSet getAllStaff()
        { 
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT staff_id, first_name, last_name, role," +
                "phone_no, email, salary, hire_date FROM Staff ORDER BY staff_id";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Staff");

            conn.Close();

            return ds;
        }
        public static DataSet getDriver()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT * FROM Staff WHERE role = 'DeliveryPerson'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Staff");

            conn.Close();

            return ds;
        }

            public static bool emailExists(string email) { 
        
            bool exists = false;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string sqlQuery = "SELECT email FROM Staff WHERE email = '" + email + "'";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            exists = cmd.ExecuteScalar() != null;
            conn.Close();
            return exists;
        }
        public static bool checkPassword(string password)
        {
            bool exists = false;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string sqlQuery = "SELECT password FROM Staff WHERE password = '" + password + "'";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            exists = cmd.ExecuteScalar() != null;
            conn.Close();
            return exists;
        }
       
    }
}
