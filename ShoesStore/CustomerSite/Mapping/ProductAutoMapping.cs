using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerSite.ViewModel.Product;
using Backend.Models;

namespace CustomerSite.Mapping
{
    public class ProductAutoMapping : Profile
    {
        public ProductAutoMapping()
        {
            //Mapping Product and ProductVM
            CreateMap<Product, ProductVM>()
                .ForMember(q=>q.BrandName, otp => otp.MapFrom(s=>s.Brand.BrandName))
                .ForMember(q=>q.CategoryName, otp => otp.MapFrom(s=>s.Category.CategoryName))
                .ForMember(q=>q.Path, otp => otp.MapFrom(s=>s.Images.FirstOrDefault().Path))
                .ReverseMap();

            //Mapping Product and Top9NewProductVM
            CreateMap<Product, Top9NewProductVM>()
                .ForMember(q=>q.Path, otp=>otp.MapFrom(s=>s.Images.FirstOrDefault().Path))
                .ReverseMap();
            
        }
    }
}
