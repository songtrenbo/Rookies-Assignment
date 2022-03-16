using Backend.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CustomerSite.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly System.Net.Http.IHttpClientFactory _clientFactory;

        private readonly IConfiguration _configuration;

        public CategoriesService(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _configuration = configuration;
        }
        public async Task<IEnumerable<Category>> GetCategories()
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync("/api/Categories/List");
            var body = await response.Content.ReadAsStringAsync();
            var categories = JsonConvert.DeserializeObject<List<Category>>(body);
            return (IEnumerable<Category>)categories;
        }
    }
}
