using AutoMapper;
using Backend.Models;
using CustomerSite.Models;
using CustomerSite.Services;
using CustomerSite.ViewModel.Image;
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
        private readonly IImageService _imageService;
        private readonly IMapper _mapper;
        public HomeController(IProductService productService, IImageService imageService, IMapper mapper)
        {
            _productService = productService;
            _imageService = imageService;
            _mapper = mapper;
        }
        //[BindProperty]
        //public Top9NewProductVM Product { get; set; }
        //[BindProperty]
        //public ImageVM Image { get; set; }

        public async Task<IActionResult> Index()
        {
            var data = await _productService.GetTop9NewProduct();
            var productMapping = _mapper.Map<IEnumerable<Top9NewProductVM>>(data);
            return View(productMapping);
        }

        public async Task<IActionResult> ProductDetail(int id)
        {
            var dataProduct = await _productService.GetProduct(id);
            var productMapping = _mapper.Map<ProductVM>(dataProduct);

            var dataImage = await _imageService.GetImages(id);
            ViewBag.Images = _mapper.Map<IEnumerable<ImageVM>>(dataImage);         
            return View(productMapping);
        }
    }
}
