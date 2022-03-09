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
    public class SizeService : ISizeService
    {
        private readonly IHttpClientFactory _clientFactory;

        private readonly IConfiguration _configuration;
        public SizeService(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _configuration = configuration;
        }

        public async Task<IEnumerable<SizeProduct>> GetSizesByProductId(int productId)
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync("/api/Sizes/ProductId/" + productId);
            var body = await response.Content.ReadAsStringAsync();
            var sizes = JsonConvert.DeserializeObject<List<SizeProduct>>(body);
            return (IEnumerable<SizeProduct>)sizes;
        }
    }
}
