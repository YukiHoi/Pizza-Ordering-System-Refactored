using System;

namespace FoodDeliverySYS.Business
{
    public interface IDeliveryStore
    {
        void DispatchOrder(
            int deliveryId, 
            int orderId,
            int staffId, 
            DateTime deliveryDate);
        void CloseDelivery(int orderId);
    }
}