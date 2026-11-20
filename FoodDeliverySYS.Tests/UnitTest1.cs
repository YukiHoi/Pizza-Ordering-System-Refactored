using System.ComponentModel;
using FoodDeliverySYS;
using FoodDeliverySYS.Business;

namespace FoodDeliverySYS.Tests
{
    public class Tests
    {

        [Test]    //check calculate total price
        public void TestCalculateTotalPrice()
        {
            decimal actual = PriceCalculator.CalculatePrice(6m, 3.5m, 6.99m, 2);

            Assert.That(actual, Is.EqualTo(32.98m));
        }

        [Test]  //check that builder keep value
        public void BuilderKeepsValue()
        {
            PizzaCart item = new PizzaBuilder()
                .WithPizzaId(1)
                .WithCrustId(2)
                .WithSizeId(3)
                .WithQuantity(4)
                .Build();

            Assert.That(item.PizzaId, Is.EqualTo(1));
            Assert.That(item.CrustId, Is.EqualTo(2));
            Assert.That(item.SizeId, Is.EqualTo(3));
            Assert.That(item.Quantity, Is.EqualTo(4));
        }

        [Test] //Test mixmum quantity
        public void Builder_RejectQuantityAboveTen() {

            PizzaBuilder builder = new PizzaBuilder()
                .WithPizzaId(1)
                .WithCrustId(2)
                .WithSizeId(3)
                .WithQuantity(12);
            Assert.Throws<ArgumentException>(() => builder.Build());
        }
        [Test] //Test valid card number
        public void CardPayment_RejectShortNumber()
        {
            CardPaymentStrategy strategy = new CardPaymentStrategy(
                "Name", "123", "11/09/33", "222");

            bool approved = strategy.Pay(30.00m);
            Assert.That(approved, Is.False);
        }
        [Test] //Check simulated Apply Pay approval
        public void ApplePay_ReturnApprovedDesion()
        {
            ApplePayPaymentStrategy strategy = new ApplePayPaymentStrategy(true);

            bool approved = strategy.Pay(33.00m);
            Assert.That(approved, Is.True);
        }
        [Test] //Check Facade handling payment declined and does not save order
        public void Facade_DeclinedPayment_DoesNotSaveOrder()
        {
            FakeOrderStore store = new FakeOrderStore();
            OrderFacade facade = new OrderFacade(store);

            PayPalPaymentStrategy strategy = new PayPalPaymentStrategy(false);

            List<PizzaCart> items = new List<PizzaCart>
            { new PizzaCart{
                PizzaId = 1,
                SizeId  = 1,
                CrustId = 1,
                Quantity = 2,
                Price = 30.00m
            }
            };
            Assert.Throws<InvalidOperationException>(() => facade.PlaceOrder(1, items, 3, strategy));
            Assert.That(store.SaveWasCalled, Is.EqualTo(false));
        }
        [Test]///Check that quantity zero is rejected
        public void Builder_RejectQuantityZero()
        {
            PizzaBuilder builder = new PizzaBuilder()
                .WithPizzaId(1)
                .WithCrustId(2)
                .WithSizeId(3)
                .WithQuantity(0);
            Assert.Throws<ArgumentException>(() => builder.Build());
        }
        [Test] //checked both allowed quantity boundaries
        public void Builder_AllowQuantityOneAndTen()
        {
            PizzaBuilder builder1 = new PizzaBuilder()
                .WithPizzaId(1)
                .WithCrustId(2)
                .WithSizeId(3)
                .WithQuantity(1);
            PizzaCart item1 = builder1.Build();
            Assert.That(item1.Quantity, Is.EqualTo(1));
            PizzaBuilder builder10 = new PizzaBuilder()
                .WithPizzaId(1)
                .WithCrustId(2)
                .WithSizeId(3)
                .WithQuantity(10);
            PizzaCart item10 = builder10.Build();
            Assert.That(item10.Quantity, Is.EqualTo(10));
        }
        [Test] //Check valid simulated card details
        public void CardPayment_ApproveValidDetails()
        {
            string expiry = DateTime.Today.AddYears(1).ToString(
                "MM/yy", System.Globalization.CultureInfo.InvariantCulture);

            CardPaymentStrategy strategy = new CardPaymentStrategy(
                "Test Customer", "1234567812345678", expiry, "222");

            bool approved = strategy.Pay(30.00m);

            Assert.That(approved, Is.True);
        }

        //Testing without opening Oracle
        public class FakeOrderStore : IOrderStore
        {
            public bool SaveWasCalled { get; private set; }

            public int SaveOrder(
                int customerId,
                List<PizzaCart> items,
                int paymentMethodId)
            {
                SaveWasCalled = true;
                return 100;
            }
        }

    }
}



