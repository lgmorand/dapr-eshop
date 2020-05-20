using eshop.common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace eshop.catalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly List<Product> Products = new List<Product>
        {
            new Product() { Id = 1, Name = "Dress 1", Price = 19, Category = "blue" },
            new Product() { Id = 2, Name = "Dress 2", Price = 29, Category = "yellow"},
            new Product() { Id = 3, Name = "Dress 3", Price = 39, Category = "blue" },
            new Product() { Id = 4, Name = "Dress 4", Price = 49, Category = "white" },
            new Product() { Id = 5, Name = "Dress 5", Price = 59, Category = "white" },
            new Product() { Id = 6, Name = "Dress 6", Price = 69, Category = "white" },
            new Product() { Id = 7, Name = "Dress 7", Price = 79, Category = "yellow"},
            new Product() { Id = 8, Name = "Dress 8", Price = 89, Category = "blue" }
        };

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            _logger.LogInformation("List products had been called");
            return Products;
        }
    }
}