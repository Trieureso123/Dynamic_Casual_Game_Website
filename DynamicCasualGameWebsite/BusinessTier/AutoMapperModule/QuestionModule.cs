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
    public static class QuestionModule
    {
        public static void ConfigQuestionModule(this IMapperConfigurationExpression mc)
        {
            mc.CreateMap<Question, QuestionResponeModel>().ReverseMap();
            mc.CreateMap<Question, QuestionRequestModel>().ReverseMap();
        }
    }
}
