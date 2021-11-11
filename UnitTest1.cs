using CKK.Logic.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CKK.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WillReturnNullIfNothingThere()
        {
            // Arrange
            Store store = new Store();

            // Act and assert
            Assert.AreEqual(null, store.FindStoreItemById(1));
        }

        [TestMethod]
        public void RemoveItem()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart(null);

            Product _product = new Product();
            _product.SetName("Product1");
            _product.SetPrice(1.58m);
            _product.SetId(48568364);

            cart.AddProduct(_product);

            // Act and assert
            Assert.AreEqual(null, cart.RemoveProduct(_product, 1).GetProduct());
        }

        [TestMethod]
        public void NewShoppingCartWillHaveNoCustomer()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart(null);

            // Act and assert
            Assert.AreEqual(0, cart.GetCustomerId());
        }

        [TestMethod]
        public void GetProductById()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart(null);

            Product _product = new Product();
            _product.SetName("Product1");
            _product.SetPrice(1.58m);
            _product.SetId(48568364);

            cart.AddProduct(_product);

            // Act and assert
            Assert.AreEqual(_product, cart.GetProductById(_product.GetId()).GetProduct());
        }

        [TestMethod]
        public void TotalWorks()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart(null);

            Product _product = new Product();
            _product.SetName("Product1");
            _product.SetPrice(1.58m);
            _product.SetId(48568364);

            Product _product2 = new Product();
            _product2.SetName("Product2");
            _product2.SetPrice(38.23m);
            _product2.SetId(38465345);

            cart.AddProduct(_product);
            cart.AddProduct(_product2, 3);

            decimal actual = _product.GetPrice() + 3 * _product2.GetPrice();

            // Act and assert
            Assert.AreEqual(actual, cart.GetTotal());
        }
    }
}
