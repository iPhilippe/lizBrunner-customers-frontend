using AutoMapper;
using LizBrunner.App.ViewModels;
using LizBrunner.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LizBrunner.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Client, ClientViewModel>().ReverseMap();

        }


    }
}
