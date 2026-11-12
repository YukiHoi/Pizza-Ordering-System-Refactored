using System;

namespace FoodDeliverySYS.Business
{
    public static class PriceCalculator
    {
       public static decimal CalculatePrice(decimal pizzaPrice, decimal crustPrice, decimal sizePrice,
            int quantity)
        {
            return (pizzaPrice + sizePrice + crustPrice) * quantity;
        }
    }
}
