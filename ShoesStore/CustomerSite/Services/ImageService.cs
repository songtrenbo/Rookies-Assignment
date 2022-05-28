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
    public class ImageService : IImageService
    {

        private readonly IHttpClientFactory _clientFactory;

        private readonly IConfiguration _configuration;

        public ImageService(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _configuration = configuration;
        }
        public async Task<IEnumerable<Image>> GetImages(int productId)
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync("/api/Images?id="+productId);
            var body = await response.Content.ReadAsStringAsync();
            var images = JsonConvert.DeserializeObject<List<Image>>(body);
            return (IEnumerable<Image>)images;
        }

    }
}
