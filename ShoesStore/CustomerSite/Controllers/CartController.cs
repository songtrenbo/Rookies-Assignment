using Backend.Models;
using CustomerSite.Models;
using CustomerSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSite.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        public CartController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Order(string dataCart)
        {
            var cart = JsonConvert.DeserializeObject<List<Cart>>(dataCart);
            var session = HttpContext.Session;
            var token = session.GetString("Token");
            double TotalPrice = 0;
            int TotaleQuantity = 0;
            foreach (var i in cart)
            {
                TotalPrice += i.productPrice*i.quantity;
                TotaleQuantity += i.quantity;
            }
            Order order = new Order
            {
                OrderTotal = TotalPrice,
                UserId = int.Parse(session.GetString("UserId"))
            };
            var orderData = await _productService.CreateOrder(order, token);
            foreach (var i in cart)
            {
                OrderDetail orderdetail = new OrderDetail
                {
                    ProductPrice = i.productPrice,
                    ProductQty = i.quantity,
                    Subtotal = i.productPrice * i.quantity,
                    OrderId = orderData.OrderId,
                    ProductId = i.productId
                };
                var oderDetaiData = await _productService.CreateOrderDetail(orderdetail, token);
            }
            return RedirectToAction("Shop", "Home");
        }
    }
}
