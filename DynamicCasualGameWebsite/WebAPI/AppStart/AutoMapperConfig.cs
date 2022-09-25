using AutoMapper;
using BusinessTier.AutoMapperModule;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.AppStart
{
    public static class AutoMapperConfig
    {
        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(mc =>
            {
                mc.ConfigQuestionModule();
                mc.ConfigFeedbackModule();
                mc.ConfigLessonModule();
            });
            IMapper mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
