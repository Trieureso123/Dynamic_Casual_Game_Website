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

            services.AddScoped<ILessonservice, LessonService>();
            services.AddScoped<ILessonRepositories, LessonRepositories>();

            services.AddScoped<IDescriptionService, DescriptionService>();
            services.AddScoped<IDescriptionRepositories, DescriptionReppsitories>();
            
            return services;
        }
    }
}
