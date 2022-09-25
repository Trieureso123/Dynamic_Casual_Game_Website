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
    public static class LessonModule
    {
        public static void ConfigLessonModule(this IMapperConfigurationExpression mc)
        {
            mc.CreateMap<Lesson, LessonRequestModel>().ReverseMap();
            mc.CreateMap<Lesson, LessonResponseModel>().ReverseMap();
        }
    }
}
