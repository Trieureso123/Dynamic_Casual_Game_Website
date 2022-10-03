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
                mc.ConfigDescriptionModule();
            });
            IMapper mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
