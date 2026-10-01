using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS
{
    internal class DBConnect
    {
        // The first connection string is used when using your laptop/PC. Check teh host name and use the Uswername and password set when 
        // you installed Oracle.
        //public const String oraDB = "Data Source = localhost/orcl; User ID = C##User1; Password = 123456;"; 

        //When in MTU Lab use this connection string
        //public const String oraDB = "Data Source = studentoracle:1521/orcl; User ID = t00256921; Password = 9E4y*9u6ackm";
        public const String oraDB = "Data Source = localhost:1521/xe; User ID = SYS; Password = Cody; DBA Privilege = SYSDBA;";
     
    }

}
