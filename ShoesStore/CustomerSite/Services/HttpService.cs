using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Shared;
using CustomerSite.Models;
using Backend.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace CustomerSite.Services
{
    public class HttpService: IHttpService
    {
        protected readonly HttpClient _httpClient; 
        private readonly IHttpClientFactory _clientFactory;
        private readonly IConfiguration _configuration;
        public HttpService(HttpClient httpClient, IConfiguration configuration, IHttpClientFactory clientFactory)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _clientFactory = clientFactory;
        }

        public async Task<Dictionary<string, string>> GetToken(string tokenEndpoint, LoginRequest request)
        {
            var tokenResponse = await PostAsync<Dictionary<string, string>>(tokenEndpoint, request);
            return tokenResponse;
        }

        public async Task<Dictionary<string, string>> RefreshToken(string tokenEndpoint, RefreshTokenRequest request)
        {
            var tokenResponse = await PostAsync<Dictionary<string, string>>(tokenEndpoint, request);
            return tokenResponse;
        }

        protected Task SetBearerToken(string accessToken)
        {

            if (accessToken != null)
            {
                _httpClient.UseBearerToken(accessToken);
            }

            return Task.CompletedTask;
        }

        public async Task<List<User>> GetAsync<T>(string url, string accessToken = null)
        {

            await SetBearerToken(accessToken);

            var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<List<User>>(body);
            return (List<User>)users;
            //var data = await response.Content.ReadAs<T>();
            //return data;
        }

        public async Task<T> PostAsync<T>(string url, object data = null, string accessToken = null)
        {

            await SetBearerToken(accessToken);

            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (data != null)
            {
                request.Content = data.AsJsonContent();
            }

            var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var createdObject = await response.Content.ReadAs<T>();
            return createdObject;
        }

        public async Task<T> PutAsync<T>(string url, object data, string accessToken = null)
        {

            await SetBearerToken(accessToken);

            var request = new HttpRequestMessage(HttpMethod.Put, url);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            request.Content = data.AsJsonContent();

            var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var updatedObject = await response.Content.ReadAs<T>();
            return updatedObject;
        }

        public async Task DeleteAsync(string url, string accessToken = null)
        {

            await SetBearerToken(accessToken);

            var request = new HttpRequestMessage(HttpMethod.Delete, url);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
        }

        public async Task<HttpResponseMessage> Register(RegisterModel model)
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var json = JsonConvert.SerializeObject(model);
            var stringModel = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/Users/register", stringModel);
            return response;
        }
    }
}
