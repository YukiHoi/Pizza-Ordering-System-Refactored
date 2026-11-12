using FoodDeliverySYS;
using FoodDeliverySYS.Business;

namespace FoodDeliverySYS.Tests;


public class Tests
{
    [Test]
    public void PizzaSize_Constructor_SetsValuesCorrectly()
    {
        var size = new PizzaSize(1, "Large", 3.50m);

        Assert.That(size.getSize_id(), Is.EqualTo(1));
        Assert.That(size.getPizza_size(), Is.EqualTo("Large"));
        Assert.That(size.getSize_price(), Is.EqualTo(3.50m));
    }

    [Test]
    public void CrustType_Constructor_SetsValuesCorrectly()
    {
        var crust = new CrustType(1, "Thin", 1.50m);

        Assert.That(crust.getCrust_id(), Is.EqualTo(1));
        Assert.That(crust.getCrust_type(), Is.EqualTo("Thin"));
        Assert.That(crust.getCrust_price(), Is.EqualTo(1.50m));
    }

    [Test]
    public void OrderDetails_Constructor_SetsValuesCorrectly()
    {
        var details = new OrderDetails(
            1, //Order_details_id
            10, //order_id
            3, //pizza_id
            2, //crust_id
            1, //size_id
            4, //quantity
            48.00m
        );

        Assert.That(details.getOrder_detail_id(), Is.EqualTo(1));
        Assert.That(details.getOrder_id(), Is.EqualTo(10));
        Assert.That(details.getPizza_id(), Is.EqualTo(3));
        Assert.That(details.getCrust_id(), Is.EqualTo(2));
        Assert.That(details.getSize_id(), Is.EqualTo(1));
        Assert.That(details.getQuantity(), Is.EqualTo(4));
        Assert.That(details.getLine_total_price(), Is.EqualTo(48.00m));
    }

    [Test]
    public void PizzaSize_Setters_UpdateValuesCorrectly()
    {
        var size = new PizzaSize();

        size.setSize_id(2);
        size.setPizza_size("Medium");
        size.setSize_price(2.50m);

        Assert.That(size.getSize_id(), Is.EqualTo(2));
        Assert.That(size.getPizza_size(), Is.EqualTo("Medium"));
        Assert.That(size.getSize_price(), Is.EqualTo(2.50m));
    }

    [Test]
    public void OrderDetails_Setters_UpdateValuesCorrectly()
    {
        var details = new OrderDetails();

        details.setQuantity(5);
        details.setLine_total_price(60.00m);

        Assert.That(details.getQuantity(), Is.EqualTo(5));
        Assert.That(details.getLine_total_price(), Is.EqualTo(60.00m));
    }

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
