using AutoMapper;
using Backend.Models;
using CustomerSite.ViewModel.Rate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSite.Mapping
{
    public class RateAutoMapping: Profile
    {
        public RateAutoMapping()
        {
            //Mapping Category and CategoryVM
            CreateMap<Rate, RateVM>()
                .ForMember(q => q.UserName, otp => otp.MapFrom(s => s.User.FirstName + " " + s.User.LastName))
                .ReverseMap();
        }
    }
}
