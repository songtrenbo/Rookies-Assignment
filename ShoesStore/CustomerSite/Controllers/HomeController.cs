using AutoMapper;
using Backend.Models;
using CustomerSite.Models;
using CustomerSite.Services;
using CustomerSite.ViewModel.Product;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public HomeController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [BindProperty]
        public ProductVM Product { get; set; }
        public async Task<IActionResult> Index()
        {
            var data = await _productService.GetTop9NewProduct();
            var productMapping = _mapper.Map<IEnumerable<Top9NewProductVM>>(data);
            return View(productMapping);
        }
    }
}
