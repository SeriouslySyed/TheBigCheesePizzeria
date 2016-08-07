using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections.Concurrent;
namespace PizzaGateway.Models
{
    public class PizzaCatalog 

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }



}