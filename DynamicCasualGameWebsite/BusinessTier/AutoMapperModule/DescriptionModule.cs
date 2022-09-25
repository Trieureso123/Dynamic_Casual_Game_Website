using AutoMapper;
using BusinessTier.RequestModels;
using BusinessTier.ViewModels;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier.AutoMapperModule
{
    public static class DescriptionModule
    {
        public static void ConfigDescriptionModule(this IMapperConfigurationExpression mc)
        {
            mc.CreateMap<Description, DescriptionResponseModel>().ReverseMap();
            mc.CreateMap<Description, DescriptionRequestModel>().ReverseMap();
        }
    }
}
