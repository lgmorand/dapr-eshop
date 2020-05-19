using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eshop.common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eshop.catalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly List<Product> Products = new List<Product>
        {
            new Product{ Name = "Dress 1", Id= 1 },
            new Product{ Name = "Dress 2", Id= 2 },
            new Product{ Name = "Dress 3", Id= 3 },
            new Product{ Name = "Dress 4", Id= 4 },
            new Product{ Name = "Dress 5", Id= 5 },
            new Product{ Name = "Dress 6", Id= 6 },
            new Product{ Name = "Dress 7", Id= 7 },
            new Product{ Name = "Dress 8", Id= 8 }
        };

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> List()
        {
            _logger.LogInformation("List products had been called");
            return Products;
        }
    }
}
