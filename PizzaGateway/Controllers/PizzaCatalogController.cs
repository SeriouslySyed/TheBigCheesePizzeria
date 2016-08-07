using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using PizzaGateway.Models;

namespace PizzaGateway.Controllers
{
    public class PizzaCatalogController : ApiController
    {
        //we will call the Pizza Catalog service to pupulate this, but for expediency we can put these in

        List<PizzaCatalog> PizzaCatalog = new List<PizzaCatalog>() 
        {
            new PizzaCatalog { Id = 1, Name = "Cheese Lover", Category = "Cheeese", Price = 1 },
            new PizzaCatalog { Id = 2, Name = "Meat Lover", Category = "Meat", Price = 3.75M },
            new PizzaCatalog { Id = 3, Name = "Vegan", Category = "Vegan", Price = 16.99M }
        };

        public IEnumerable<PizzaCatalog> GetPizzaCatalog()
        {
            return PizzaCatalog;
        }

        public IHttpActionResult GetPizzaCatalog(int id)
        {
            var product = PizzaCatalog.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}