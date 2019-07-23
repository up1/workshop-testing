using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WorkshopNTL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return new Product[] {
                new Product(1, "Product 1", 1.000),
                new Product(2, "Product 2", 2.000),
                new Product(3, "Product 3", 3.000),
                new Product(4, "Product 4", 4.000),
                new Product(5, "Product 5", 5.000),
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        public bool check()
        {
            return true;
        }
    }
}
