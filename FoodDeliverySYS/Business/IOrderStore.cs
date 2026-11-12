using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySYS.Business
{
    public interface IOrderStore
    {
        //Save one order, all items and one payment together.
        int SaveOrder(
            int customerId,
            IReadOnlyList<PizzaCart> items,
            int paymentMethodId
            );
    }
}
