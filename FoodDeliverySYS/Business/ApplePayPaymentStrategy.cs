using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySYS.Business
{
    public class ApplePayPaymentStrategy : IPaymentStrategy
    {
        private readonly bool approved;

        public ApplePayPaymentStrategy(bool approved)
        {
            this.approved = approved;
        }
        public bool Pay(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException(
                    "Payment amount must be greater than zero");
            return approved;
        }
    }
}
