using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySYS.Models
{
    public class OrderItem
    {
        internal decimal totalPrice;

        public int OrderID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice {get;  set; }

        public string PizzaName { get; internal set; }
        public string CrustType { get; internal set; }
        public string Size { get; internal set; }
        public List<Topping> SelectedToppings { get; internal set; }
    }
}
 