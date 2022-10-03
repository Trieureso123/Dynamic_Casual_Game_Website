using Microsoft.Extensions.DependencyInjection;
using WebApplication.Repositories;

namespace WebApplication.AppStart
{
    public static class DependencyInjectionResolver
    {
        public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<ILessonRepository, LessonRepository>();
            
            
            services.AddScoped<IDescriptionRepository, DescriptionRepository>();
        
        
            return services;
        }
    }
}
