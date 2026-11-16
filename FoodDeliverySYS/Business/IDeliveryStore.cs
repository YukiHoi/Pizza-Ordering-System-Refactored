using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySYS.Business
{
    public interface IDeliveryStore
    {
        // Save the delivery and update the order together.
        void DispatchOrder(
            int deliveryId,
            int orderId,
            int staffId,
            DateTime deliveryDate);

        // Update a dispatched order to delivered.
        void CloseDelivery(int orderId);
    }
}
