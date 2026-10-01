using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySYS.Models
{
        public class Customer
        {
            public int CustomerID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string County { get; set; }
            public string Town { get; set; }
            public string Eircode { get; set; }
            public string PhoneNumber { get; set; }
        }

        
    }



