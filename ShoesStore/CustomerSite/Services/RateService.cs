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
    public class RateService : IRateService
    {
        private readonly IHttpClientFactory _clientFactory;

        private readonly IConfiguration _configuration;
        public RateService(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _configuration = configuration;
        }
        public async Task<IEnumerable<Rate>> GetRates()
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync("/api/Rates");
            var body = await response.Content.ReadAsStringAsync();
            var rates = JsonConvert.DeserializeObject<List<Rate>>(body);
            return (IEnumerable<Rate>)rates;
        }

        public async Task<IEnumerable<Rate>> GetRatesByProductId(int productId)
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync("/api/Rates/Product/" + productId);
            var body = await response.Content.ReadAsStringAsync();
            var rates = JsonConvert.DeserializeObject<List<Rate>>(body);
            return (IEnumerable<Rate>)rates;
        }
        public async Task<double> GetSumRateByProductId(int productId)
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync("/api/Rates/RatePoints/" + productId);
            var body = await response.Content.ReadAsStringAsync();
            var ratePoints = JsonConvert.DeserializeObject<double>(body);
            return ratePoints;
        }
    }
}
