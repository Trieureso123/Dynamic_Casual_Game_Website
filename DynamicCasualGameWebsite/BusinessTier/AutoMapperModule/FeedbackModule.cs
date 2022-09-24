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
    public static class FeedbackModule
    {
        public static void ConfigFeedbackModule(this IMapperConfigurationExpression mc)
        {
            mc.CreateMap<Feedback, FeedbackResponeModel>().ReverseMap();
            mc.CreateMap<Feedback, FeedbackRequestModel>().ReverseMap();
        }
    }
}
