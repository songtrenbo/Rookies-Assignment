using CustomerSite.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CustomerSite.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        private readonly IHttpService _httpService;

        public UserController(ILogger<UserController> logger, IUserService userService, IHttpService httpService)
        {
            _logger = logger;
            _userService = userService;
            _httpService = httpService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "home");
            }
            //await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest req)
        {
                if (!ModelState.IsValid)
                {
                    return View(ModelState);
                }
                var tokenResponse = await _httpService.GetToken("https://localhost:44379/api/users/login", req);
            if (tokenResponse == null)
            {
                
                return View();
            }
                var session = HttpContext.Session;
                session.SetString("Fullname", tokenResponse["fullName"]);
                session.SetString("Token", tokenResponse["accessToken"]);
                session.SetString("UserId", tokenResponse["userId"]); 

                return RedirectToAction("index", "Home");

        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel req)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(ModelState);
                }

                var result = await _httpService.Register(req);
                return RedirectToAction("Login");

            }
            catch
            {
                return View();
            }
        }
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Remove("Fullname");
            return RedirectToAction("Login");
        }
        public IActionResult Index()
        {
            return View();
        }


        public void CountAccess(HttpContext context)
        {
            // Lấy ISession
            var session = context.Session;
            string key_access = "info_access";

            // Lưu vào  Session thông tin truy cập
            // Định nghĩa cấu trúc dữ liệu lưu trong Session
            var accessInfoType = new
            {
                count = 0,
                lasttime = DateTime.Now
            };

            // Đọc chuỗi lưu trong Sessin với key = info_access
            string json = session.GetString(key_access);
            dynamic lastAccessInfo;
            if (json != null)
            {
                // Convert chuỗi Json - thành đối tượng có cấu trúc như accessInfoType
                lastAccessInfo = JsonConvert.DeserializeObject(json, accessInfoType.GetType());
            }
            else
            {
                // json chưa từng lưu trong Session, accessInfo lấy bằng giá trị khởi  tạo
                lastAccessInfo = accessInfoType;
            }

            // Cập nhật thông tin
            var accessInfoSave = new
            {
                count = lastAccessInfo.count + 1,
                lasttime = DateTime.Now
            };

            // Convert accessInfo thành chuỗi Json và lưu lại vào Session
            string jsonSave = JsonConvert.SerializeObject(accessInfoSave);
            session.SetString(key_access, jsonSave);
            Console.WriteLine(jsonSave);
        }
    }
}
