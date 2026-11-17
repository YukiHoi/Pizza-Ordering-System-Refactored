using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliverySYS.Business;

namespace FoodDeliverySYS.Business
{
    public interface IPaymentStrategy
    {
        bool Pay(decimal amount);
    }
}


