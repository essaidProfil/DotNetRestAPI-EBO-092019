using System;
using Catalogue.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catalogue.Tests.Controllers
{
    [TestClass]
    public class OrderControllerTest
    {
        private string id;
        private Order order;

        /// <summary>
        /// Get all order Tests
        /// </summary>
        [TestMethod]
        public void Get_ALL_Orders()
        {
            OrderControllerTest controller = new OrderControllerTest();

            var results = CosmosDbStorage<Order>.GetItemsAsync(o => o.Id != null);

            Assert.IsNotNull(results);
        }

        /// <summary>
        /// Test Methode - Ajouter un produit au panier
        /// </summary>
        [TestMethod]
        public void Place_Order() {
            OrderControllerTest Controller = new OrderControllerTest();

            var results = CosmosDbStorage<Order>.CreateItemAsync(order);

            Assert.IsNotNull(results);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        [TestMethod]
        public void DeleteOrder() {

            OrderControllerTest Controller = new OrderControllerTest();
            var result = CosmosDbStorage<Order>.DeleteAsync(id);
            Assert.IsNotNull(result);
        }

    }
}
