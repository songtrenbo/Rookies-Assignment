using AutoMapper;
using Backend.Models;
using CustomerSite.ViewModel.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSite.Mapping
{
    public class CategoryAutoMapping : Profile
    {
        public CategoryAutoMapping()
        {
            //Mapping Category and CategoryVM
            CreateMap<Category, CategoryVM>().ReverseMap();
        }
    }
}
