using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySYS.Models
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        public string PizzaName { get; set; }
        public List<string> Crusts { get; set; } = new List<string>();
        public Dictionary<string, decimal> Sizes { get; set; } = new Dictionary<string, decimal>();
        public List<Topping> Toppings { get; set; } = new List<Topping>();
        public string CrustType { get; internal set; }
        public string PizzaSize { get; internal set; }
        public decimal TotalPrice { get; internal set; }
    }
 
}
