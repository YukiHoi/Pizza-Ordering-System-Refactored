using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodDeliverySYS.Business
{
    public class OrderFacade
    {
        private readonly IOrderStore orderStore;

        public OrderFacade(IOrderStore orderStore)
        {
            if (orderStore == null)
            {
                throw new ArgumentNullException(nameof(orderStore));
            }

            this.orderStore = orderStore;
        }

        public int PlaceOrder(
            int customerId,
            List<PizzaCart> items,
            int paymentMethodId,
            IPaymentStrategy paymentStrategy)
        {
            if (customerId <= 0)
            {
                throw new ArgumentException("A customer is required.");
            }

            if (items == null || items.Count == 0)
            {
                throw new ArgumentException("The cart is empty.");
            }

            if (paymentMethodId <= 0)
            {
                throw new ArgumentException("A payment method is required.");
            }

            decimal total = items.Sum(item => item.Price);

            if (!paymentStrategy.Pay(total))
            {
                throw new InvalidOperationException(
                    "Payment was declined or the details are invalid.");
            }

            // Save only after simulated payment approval.
            return orderStore.SaveOrder(
                customerId, items, paymentMethodId);
        }
    }
}