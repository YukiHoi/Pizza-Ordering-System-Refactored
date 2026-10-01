using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySYS.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }
        public decimal TotalPrice { get; set; }
        public object CustomerID { get; internal set; }
        public DateTime OrderDate { get; internal set; }
        public object Pizza { get; internal set; }
        public object TotalAmount { get; internal set; }
    }
}
