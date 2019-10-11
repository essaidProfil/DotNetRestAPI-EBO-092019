using System;
using System.Collections.Generic;
using System.Linq;
using Catalogue.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catalogue.Tests.Controllers
{
    [TestClass]
    public class ProductController
    {
        [TestMethod]
        public void GetItemsAsync()
        {
            // Arrange
            ProductController controller = new ProductController();

            // Act
            var results = CosmosDbStorage<Product>.GetItemsAsync(p => p.InStock);
            // Assert
            Assert.IsNotNull(results);
        }
        [TestMethod]
        public void GetProduct_byId() {

            ProductController controller = new ProductController();

            var result = CosmosDbStorage<Product>.GetItemsAsync(d => d.InStock == true);

            Assert.IsNotNull(result);
        }
    }
}
