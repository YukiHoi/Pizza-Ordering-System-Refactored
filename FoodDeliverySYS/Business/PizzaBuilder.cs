using System;

namespace FoodDeliverySYS.Business
{ 
    public class PizzaBuilder
    {
        private int pizzaId;
        private int sizeId;
        private int crustId;
        private int quantity;

        public PizzaBuilder WithPizzaId(int Id)
        {
            pizzaId = Id;
            return this;
        }

        public PizzaBuilder WithSizeId(int Id)
        {
            sizeId = Id;
            return this;
        }

        public PizzaBuilder WithCrustId(int Id)
        {
            crustId = Id;
            return this;
        }

        public PizzaBuilder WithQuantity(int value)
        {
            quantity = value;
            return this;
        }

        public PizzaCart Build()
        {
            if (quantity < 1 || quantity > 10)
            {
                throw new ArgumentException("Quantity must be between 1 and 10");
            }
            return new PizzaCart
            {
                PizzaId = pizzaId,
                SizeId = sizeId,
                CrustId = crustId,
                Quantity = quantity
            };
        }

        internal object SetName(string v)
        {
            throw new NotImplementedException();
        }
    }
}