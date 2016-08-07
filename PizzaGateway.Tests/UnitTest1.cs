using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaGateway.Models;
using PizzaGateway.Controllers;
using System.Web.Http.Results;


namespace PizzaGateway.Tests
{
    [TestClass]
    public class TestPizzaCatalogController
    {
        [TestMethod]
        public void GetPizzaCatalog_ShouldReturnFullCatalog()
        {
   
            var testProducts = GetTestPizzaCatalog();
            var controller = new PizzaCatalogController();
            //simple test as our pizza catalog only contains 3 types
            var result =  controller.GetPizzaCatalog() as List<PizzaCatalog>;
            Assert.AreEqual(testProducts.Count, result.Count);

        }

        private List<PizzaCatalog> GetTestPizzaCatalog()    
        {
            var testProducts = new List<PizzaCatalog>();
            testProducts.Add(new PizzaCatalog { Id = 1, Name = "Cheesy2", Price = 1 });
            testProducts.Add(new PizzaCatalog { Id = 2, Name = "Meaty2", Price = 3.75M });
            testProducts.Add(new PizzaCatalog { Id = 3, Name = "Vegan2", Price = 16.99M });

            return testProducts;
        }
    }
}
