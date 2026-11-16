using FoodDeliverySYS;
using FoodDeliverySYS.Business;

namespace FoodDeliverySYS.Tests;


public class Tests
{
    [Test]
    public void PriceCalculator_Calculate_ReturnsCorrectTotal()
    {
        decimal pizzaPrice = 10.00m;
        decimal crustPrice = 2.00m;
        decimal sizePrice = 3.00m;
        int quantity = 1;

        decimal actual = PriceCalculator.CalculatePrice(pizzaPrice, crustPrice, sizePrice, quantity);
        Assert.That(actual, Is.EqualTo(15.00m));
    }

    [Test]
    public void Calculate_HandlesPriceWithDecimalValues()
    {
        decimal actual = PriceCalculator.CalculatePrice(10.50m, 2.25m, 3.75m, 2);

        Assert.That(actual, Is.EqualTo(33m));
    }



    [Test]
    public void PizzaCartBuilder_Build_ReturnSelectedValues()
    {
        var item = new PizzaCartBuilder()
            .WithPizzaId(3)
            .WithSizeId(2)
            .WithCrustId(1)
            .WithQuantity(2)
            .Build();

        Assert.That(item.PizzaId, Is.EqualTo(3));
        Assert.That(item.SizeId, Is.EqualTo(2));
        Assert.That(item.CrustId, Is.EqualTo(1));
        Assert.That(item.Quantity, Is.EqualTo(2));
    }
    [Test]
    public void PizzaCartBuilder_Build_ThrowsExceptionForInvalidQuantity()
    {
        Assert.Throws<System.ArgumentException>(() => new PizzaCartBuilder()
            .WithPizzaId(3)
            .WithSizeId(2)
            .WithCrustId(1)
            .WithQuantity(11)
            .Build());
    }
    //Test PayPalPaymentStrategy
    [TestCase(true)]
    [TestCase(false)]
    public void PayPal_ReturnsApprovalDecision(bool approved)
    {
        var strategy = new PayPalPaymentStrategy(approved);

        Assert.That(strategy.Pay(20m), Is.EqualTo(approved));
    }

    [Test]
    public void Card_WithValidDetails_ReturnsTrue()
    {
        string expiry = System.DateTime.Today
            .AddYears(1).ToString("MM/yy",
                System.Globalization.CultureInfo.InvariantCulture);

        var strategy = new CardPaymentStrategy(
            "Test Customer", "1234567812345678", expiry, "123");

        Assert.That(strategy.Pay(20m), Is.True);
    }

    [Test]
    public void Card_WithShortCardNumber_ReturnsFalse()
    {
        string expiry = System.DateTime.Today
            .AddYears(1).ToString("MM/yy",
                System.Globalization.CultureInfo.InvariantCulture);

        var strategy = new CardPaymentStrategy(
            "Test Customer", "1234", expiry, "123");

        Assert.That(strategy.Pay(20m), Is.False);
    }

    [Test]
    public void Card_WithExpiredDate_ReturnsFalse()
    {
        string expiry = System.DateTime.Today
            .AddYears(-1).ToString("MM/yy",
                System.Globalization.CultureInfo.InvariantCulture);

        var strategy = new CardPaymentStrategy(
            "Test Customer", "1234567812345678", expiry, "123");

        Assert.That(strategy.Pay(20m), Is.False);
    }
}
