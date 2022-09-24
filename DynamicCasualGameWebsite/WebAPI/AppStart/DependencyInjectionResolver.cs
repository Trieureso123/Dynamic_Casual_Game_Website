using BusinessTier.Services;
using DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.AppStart
{
    public static class DependencyInjectionResolver
    {
        public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IQuestionRepository, QuestionRepositories>();

            services.AddScoped<IFeedbackService, FeedbackService>();
            services.AddScoped<IFeedbackRepositories, FeedbackRepositories>();
            
            return services;
        }
    }
}
