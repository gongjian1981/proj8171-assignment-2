using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProductManager.nunitTests
{
    internal class ProductTests
    {
        // Test ProductID boundaries
        [Test]
        public void SetProductID_Min_ShouldBeValid()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Backpack", 100.0m, 100);
            //Assert that the expected results have occurred
            Assert.That(product.ProductID, Is.EqualTo(1));
        }

        [Test]
        public void SetProductID_Mid_ShouldBeValid()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(5000, "Chair", 200.0m, 50);
            //Assert that the expected results have occurred
            Assert.That(product.ProductID, Is.EqualTo(5000));
        }

        [Test]
        public void SetProductID_Max_ShouldBeValid()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(10000, "Apple", 100.0m, 50);
            //Assert that the expected results have occurred
            Assert.That(product.ProductID, Is.EqualTo(10000));
        }
        // Test ProductName
        [Test]
        public void SetProductName_Test1_ShouldBeValid()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Lamp", 40.0m, 1000);
            //Assert that the expected results have occurred
            Assert.That(product.ProductName, Is.EqualTo("Lamp"));
        }

        [Test]
        public void SetProductName_Test2_ShouldBeValid()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Shampoo", 20.0m, 350);
            //Assert that the expected results have occurred
            Assert.That(product.ProductName, Is.EqualTo("Shampoo"));
        }

        [Test]
        public void SetProductName_Test3_ShouldBeValid()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Television", 350.0m, 350);
            //Assert that the expected results have occurred
            Assert.That(product.ProductName, Is.EqualTo("Television"));
        }

        // Test Price boundaries
        [Test]
        public void SetPrice_Min_ShouldBeValid()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Mint", 1.0m, 50);
            //Assert that the expected results have occurred
            Assert.That(product.Price, Is.EqualTo(1.0m));
        }

        [Test]
        public void SetPrice_Mid_ShouldBeValid()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Printer", 5000.0m, 500);
            //Assert that the expected results have occurred
            Assert.That(product.Price, Is.EqualTo(5000.0m));
        }

        [Test]
        public void SetPrice_Max_ShouldBeValid()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Television", 5000.0m, 5000);
            //Assert that the expected results have occurred
            Assert.That(product.Price, Is.EqualTo(5000.0m));
        }

        // Test Stock boundaries
        [Test]
        public void SetStock_Min_ShouldBeValid()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Headphones", 100.0m, 1);
            //Assert that the expected results have occurred
            Assert.That(product.Stock, Is.EqualTo(1));
        }

        [Test]
        public void SetStock_Mid_ShouldBeValid()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Laptop", 1000.0m, 50000);
            //Assert that the expected results have occurred
            Assert.That(product.Stock, Is.EqualTo(50000));
        }

        [Test]
        public void SetStock_Max_ShouldBeValid()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Wallet", 100.0m, 100000);
            //Assert that the expected results have occurred
            Assert.That(product.Stock, Is.EqualTo(100000));
        }

        // Test IncreaseStock functionality
        [Test]
        public void IncreaseStock_By100_ShouldIncrease()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Scooter", 100.0m, 50);
            //Act on the object or method under test.
            product.IncreaseStock(100);
            //Assert that the expected results have occurred
            Assert.That(product.Stock, Is.EqualTo(150));
        }

        [Test]
        public void IncreaseStock_By0_ShouldNotChange()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Blanket", 100.0m, 999);
            //Act on the object or method under test.
            product.IncreaseStock(0);
            //Assert that the expected results have occurred
            Assert.That(product.Stock, Is.EqualTo(999));
        }

        [Test]
        public void IncreaseStock_ToMax_ShouldBeValid()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Sandals", 100.0m, 99999);
            //Act on the object or method under test.
            product.IncreaseStock(1);
            //Assert that the expected results have occurred
            Assert.That(product.Stock, Is.EqualTo(100000));
        }

        // Test DecreaseStock functionality
        [Test]
        public void DecreaseStock_By200_ShouldDecrease()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Gloves", 15.0m, 750);
            //Act on the object or method under test.
            product.DecreaseStock(200);
            //Assert that the expected results have occurred
            Assert.That(product.Stock, Is.EqualTo(550));
        }

        [Test]
        public void DecreaseStock_By0_ShouldNotChange()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Drone", 1000.0m, 777);
            //Act on the object or method under test.
            product.DecreaseStock(0);
            //Assert that the expected results have occurred
            Assert.That(product.Stock, Is.EqualTo(777));
        }

        [Test]
        public void DecreaseStock_ToMin_ShouldBeValid()
        {
            //Arrange all necessary preconditions and inputs
            Product product = new Product(1, "Clock", 60.0m, 1111);
            //Act on the object or method under test.
            product.DecreaseStock(1110);
            //Assert that the expected results have occurred
            Assert.That(product.Stock, Is.EqualTo(1));
        }
    }
}
