using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CustomerSite.Services
{
    public interface IUserService
    {
        Task<string> Login(LoginModel req);
        ClaimsPrincipal ValidateToken(string jwtToken);
        //Task<bool> RegisterUser(RegisterRequest registerRequest);
    }
}
