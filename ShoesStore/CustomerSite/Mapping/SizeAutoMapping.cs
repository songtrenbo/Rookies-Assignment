using AutoMapper;
using Backend.Models;
using CustomerSite.ViewModel.Size;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSite.Mapping
{
    public class SizeAutoMapping : Profile
    {
        public SizeAutoMapping()
        {
            //Mapping Image and ImageVM
            CreateMap<SizeProduct, SizeVM>()
                .ForMember(q=>q.SizeName, otp=>otp.MapFrom(s=>s.Size.SizeName))
                .ReverseMap();
        }
    }
}
