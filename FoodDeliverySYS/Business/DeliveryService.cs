using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FoodDeliverySYS.Business
{
    public class DeliveryService
    {
        private readonly IDeliveryStore deliveryStore;

        public DeliveryService(IDeliveryStore deliveryStore)
        {
            if (deliveryStore == null)
                throw new ArgumentNullException(nameof(deliveryStore));

            this.deliveryStore = deliveryStore;
        }

        public void DispatchOrder(
            int deliveryId, 
            int orderId,
            int staffId, 
            DateTime deliveryDate)
        {
            deliveryStore.DispatchOrder(
                deliveryId, orderId, staffId, deliveryDate);
        }

        public void CloseDelivery(int orderId)
        {
            deliveryStore.CloseDelivery(orderId);
        }
    }
}

