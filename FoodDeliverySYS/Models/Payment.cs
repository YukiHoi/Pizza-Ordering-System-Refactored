using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySYS.Models
{
    public class Payment
    {
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public bool IsSuccessful { get; set; }
    }
}
