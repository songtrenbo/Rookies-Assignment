using Backend.Models;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CustomerSite.Services
{
    public interface IHttpService
    {
        public Task<Dictionary<string, string>> GetToken(string tokenEndpoint, LoginRequest request);
        public Task<Dictionary<string, string>> RefreshToken(string tokenEndpoint, RefreshTokenRequest request);


        public Task<List<User>> GetAsync<T>(string url, string accessToken = null);
        public Task<T> PostAsync<T>(string url, object data = null, string accessToken = null);
        public Task<T> PutAsync<T>(string url, object data, string accessToken = null);

        public Task DeleteAsync(string url, string accessToken = null);
        public Task<HttpResponseMessage> Register(RegisterModel model);
    }
}
