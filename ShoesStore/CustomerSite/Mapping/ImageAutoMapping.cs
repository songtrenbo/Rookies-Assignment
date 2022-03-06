using AutoMapper;
using Backend.Models;
using CustomerSite.ViewModel.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSite.Mapping
{
    public class ImageAutoMapping:Profile
    {
        public ImageAutoMapping()
        {
            //Mapping Image and ImageVM
            CreateMap<Image, ImageVM>().ReverseMap();
        }
    }
}
