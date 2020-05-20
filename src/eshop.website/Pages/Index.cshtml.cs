using Dapr.Client;
using Dapr.Client.Http;
using eshop.common;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace eshop.website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DaprClient _daprClient;
        public List<Product> Products = null;
        private readonly IConfiguration _configuration;

        public IndexModel(ILogger<IndexModel> logger, DaprClient daprClient, IConfiguration configuration)
        {
            _logger = logger;
            _daprClient = daprClient;
            _configuration = configuration;
        }

        public async void OnGet()
        {
            Products = await GetProducts();
        }

        private async Task<List<Product>> GetProducts()
        {
            try
            {
                if (_configuration.GetValue<bool>("TEST_MODE"))
                {
                    // fake data
                    var products = new List<Product>();
                    products.Add(new Product() { Id = 1, Name = "Dress 1", Price = 19, Category = "blue" });
                    products.Add(new Product() { Id = 2, Name = "Dress 2", Price = 29, Category = "yellow" });
                    products.Add(new Product() { Id = 3, Name = "Dress 3", Price = 39, Category = "blue" });
                    products.Add(new Product() { Id = 4, Name = "Dress 4", Price = 49, Category = "white" });
                    products.Add(new Product() { Id = 5, Name = "Dress 5", Price = 59, Category = "white" });
                    products.Add(new Product() { Id = 6, Name = "Dress 6", Price = 69, Category = "white" });
                    products.Add(new Product() { Id = 7, Name = "Dress 7", Price = 79, Category = "yellow" });
                    products.Add(new Product() { Id = 8, Name = "Dress 8", Price = 89, Category = "blue" });
                    return products;
                }
                else return await _daprClient.InvokeMethodAsync<List<Product>>(Constants.Services.Catalog.Name, Constants.Services.Catalog.Actions.List, DaprHelper.GetGetHttpExtension());
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message, ex);
            }


            return null;
        }

    }
}