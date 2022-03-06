using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace CustomerSite.Services
{
    public class ProductService : IProductService
    {

        private readonly IHttpClientFactory _clientFactory;

        private readonly IConfiguration _configuration;

        public ProductService(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _configuration = configuration;
        }
        public async Task<IEnumerable<Product>> GetProducts()
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync("/api/Products");
            var body = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<List<Product>>(body);
            return (IEnumerable<Product>)products;        
        }

        public async Task<IEnumerable<Product>> GetTop9NewProduct()
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync("/api/Products/GetTop9NewProduct");
            var body = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<List<Product>>(body);
            return (IEnumerable<Product>)products;
        }

        public async Task<Product> GetProduct(int productId)
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync("/api/Products/" + productId);
            var body = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<Product>(body);
            return product;
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(int categoryId)
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync("/api/Products/Category/" + categoryId);
            var body = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<List<Product>>(body);
            return (IEnumerable<Product>)products;
        }
    }
}
