using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySYS.Business
{
    public class OrderFacade
    {
        private readonly IOrderStore orderStore;
        
        public OrderFacade(IOrderStore orderStore)
        {
            if (orderStore == null)
                throw new ArgumentNullException(nameof(orderStore));

            this.orderStore = orderStore;
        }
        public int PlaceOrder(
            int customerId,
            IReadOnlyList<PizzaCart> items,
            int paymentMethodId)
        {
            // Ask the supplied store to save the complete order.
            return orderStore.SaveOrder(
                customerId, items, paymentMethodId);
        }
    }
}
