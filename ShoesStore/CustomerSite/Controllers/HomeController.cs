using AutoMapper;
using Backend.Models;
using CustomerSite.Models;
using CustomerSite.Services;
using CustomerSite.ViewModel.Category;
using CustomerSite.ViewModel.Image;
using CustomerSite.ViewModel.Product;
using CustomerSite.ViewModel.Size;
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
        private readonly ICategoriesService _categoriesService;
        private readonly ISizeService _sizeService;
        private readonly IMapper _mapper;
        public HomeController(IProductService productService, IImageService imageService, ICategoriesService categoriesService, ISizeService sizeService,IMapper mapper)
        {
            _productService = productService;
            _imageService = imageService;
            _categoriesService = categoriesService;
            _sizeService = sizeService;
            _mapper = mapper;
        }
        //[BindProperty]
        //public Top9NewProductVM Product { get; set; }
        //[BindProperty]
        //public ImageVM Image { get; set; }

        //Home page
        public async Task<IActionResult> Index()
        {
            var data = await _productService.GetTop9NewProduct();
            var productMapping = _mapper.Map<IEnumerable<Top9NewProductVM>>(data);
            return View(productMapping);
        }

        //Product detail page
        public async Task<IActionResult> ProductDetail(int id)
        {
            var dataProduct = await _productService.GetProduct(id);
            var productMapping = _mapper.Map<ProductVM>(dataProduct);

            var dataSize = await _sizeService.GetSizesByProductId(id);
            ViewBag.Sizes = _mapper.Map<IEnumerable<SizeVM>>(dataSize);

            var dataImage = await _imageService.GetImages(id);
            ViewBag.Images = _mapper.Map<IEnumerable<ImageVM>>(dataImage);         
            return View(productMapping);
        }

        //List of products
        public async Task<IActionResult> Shop(int categoryId)
        {
            var dataCategories = await _categoriesService.GetCategories();
            var categoryMapping = _mapper.Map<IEnumerable<CategoryVM>>(dataCategories);
            ViewBag.Categories = categoryMapping;
            if (categoryId == 0)
            {
                var dataProducts = await _productService.GetProducts();
                var productMapping = _mapper.Map<IEnumerable<ProductVM>>(dataProducts);
                ViewBag.CategorieName = "ALL PRODUCTS";
                return View(productMapping);
            }
            else
            {
                var dataProducts = await _productService.GetProductsByCategory(categoryId);
                var productMapping = _mapper.Map<IEnumerable<ProductVM>>(dataProducts);
                ViewBag.CategorieName = categoryMapping.Where(s => s.CategoryId == categoryId).FirstOrDefault().CategoryName;
                return View(productMapping);
            }
        }
    }
}
