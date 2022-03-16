using AutoMapper;
using Backend.Models;
using Shared.Dto.Brand;
using Shared.Dto.Category;
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
        }

    }
}
