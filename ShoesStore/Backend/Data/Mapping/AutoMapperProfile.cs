using AutoMapper;
using Backend.Models;
using Shared.Dto.Brand;
using Shared.Dto.Category;
using Shared.Dto.Product;
using Shared.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data.Migrations
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Brand, BrandDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Product, ProductDto>()
                .ForMember(q=>q.BrandName, otp=>otp.MapFrom(s=>s.Brand.BrandName))
                .ForMember(q=>q.CategoryName, otp=>otp.MapFrom(s=>s.Category.CategoryName));
            CreateMap<User, UserDto>()
                .ForMember(q=>q.Name, otp=>otp.MapFrom(s=>s.FirstName+" "+s.LastName));
        }

    }
}
