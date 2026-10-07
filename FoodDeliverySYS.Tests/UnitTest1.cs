using FoodDeliverySYS;
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
                3,//pizza_id
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
}
