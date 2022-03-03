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
            CreateMap<Product, ProductVM>().ReverseMap();
            CreateMap<Product, Top9NewProductVM>().ForMember(q=>q.Path, otp=>otp.MapFrom(s=>s.Images.FirstOrDefault().Path)).ReverseMap();
        }
    }
}
