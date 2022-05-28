using AutoMapper;
using Backend.Models;
using CustomerSite.Models;
using CustomerSite.Services;
using CustomerSite.ViewModel.Category;
using CustomerSite.ViewModel.Image;
using CustomerSite.ViewModel.Product;
using CustomerSite.ViewModel.Rate;
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
        private readonly IRateService _rateService;
        private readonly IMapper _mapper;
        public HomeController(IProductService productService, IImageService imageService, ICategoriesService categoriesService, ISizeService sizeService, IRateService rateService,IMapper mapper)
        {
            _productService = productService;
            _imageService = imageService;
            _categoriesService = categoriesService;
            _sizeService = sizeService;
            _rateService = rateService;
            _mapper = mapper;
        }

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
            //Get rate points of product by Id
            var dataRates = await _rateService.GetSumRateByProductId(id);
            var ratePointMapping = _mapper.Map<double>(dataRates);
            ViewBag.Points = ratePointMapping;

            //Get all rates and comment of product
            var dataRatesNComment = await _rateService.GetRatesByProductId(id);
            var rateNCommentMapping = _mapper.Map<IEnumerable<RateVM>>(dataRatesNComment);
            ViewBag.RateNComment = rateNCommentMapping;

            //Get sizes of product by Id
            var dataSize = await _sizeService.GetSizesByProductId(id);
            ViewBag.Sizes = _mapper.Map<IEnumerable<SizeVM>>(dataSize);

            //Get images of product by Id
            var dataImage = await _imageService.GetImages(id);
            var images = _mapper.Map<IEnumerable<ImageVM>>(dataImage);
            ViewBag.Images = images;
            ViewBag.FirstImage = images.First();

            //Get 1 product by Id
            var dataProduct = await _productService.GetProduct(id);
            var productMapping = _mapper.Map<ProductVM>(dataProduct);
            return View(productMapping);
        }

        //List of products
        public async Task<IActionResult> Shop(int categoryId)
        {
            //Get List of categories and pass it to ViewBag.Categories
            var dataCategories = await _categoriesService.GetCategories();
            var categoryMapping = _mapper.Map<IEnumerable<CategoryVM>>(dataCategories);
            ViewBag.Categories = categoryMapping;

            //Check if categoryId is = 0 or > 0
            //if categoryId = 0 return all products
            //else return products in that category
            if (categoryId == 0)
            {
                //Get list of products
                var dataProducts = await _productService.GetProducts();
                var productMapping = _mapper.Map<IEnumerable<ProductVM>>(dataProducts);

                //Declare an array to hold rate points of each products
                double[] arrProductPoints = new double[productMapping.Count()];
                int i = 0;
                foreach (var productItem in productMapping)
                {
                    //Get points from each product then pass it to the arra arrProductPoints
                    var dataRates = await _rateService.GetSumRateByProductId(productItem.ProductId);
                    var ratePointMapping = _mapper.Map<double>(dataRates);
                    arrProductPoints[i] = ratePointMapping;
                    i++;
                }
                ViewBag.Points = arrProductPoints;
                ViewBag.CategorieName = "ALL PRODUCTS";
                return View(productMapping);
            }
            else
            {
                //Get a list of products with categoryId 
                var dataProducts = await _productService.GetProductsByCategory(categoryId);
                var productMapping = _mapper.Map<IEnumerable<ProductVM>>(dataProducts);

                //Declare an array to hold rate points of each products
                double[] arrProductPoints = new double[productMapping.Count()];
                int i = 0;
                foreach (var productItem in productMapping)
                {
                    //Get points from each product then pass it to the arra arrProductPoints
                    var dataRates = await _rateService.GetSumRateByProductId(productItem.ProductId);
                    var ratePointMapping = _mapper.Map<double>(dataRates);
                    arrProductPoints[i] = ratePointMapping;
                    i++;
                }
                ViewBag.Points = arrProductPoints;
                var category = categoryMapping.Where(s => s.CategoryId == categoryId).FirstOrDefault();
                ViewBag.CategorieName = category.CategoryName;
                ViewBag.CategorieDesc = category.Description;
                return View(productMapping);
            }
        }

    }
}
