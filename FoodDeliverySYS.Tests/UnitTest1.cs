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
}
