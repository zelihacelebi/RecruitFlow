using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using RecruitFlow.Application.Interfaces.Repositories;
using RecruitFlow.Application.Interfaces.Services;
using RecruitFlow.Application.Mappings;
using RecruitFlow.Application.Services;

namespace RecruitFlow.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(
                typeof(DependencyInjection).Assembly);

            // AutoMapper
            services.AddAutoMapper(cfg =>
            {
            }, typeof(MappingProfile).Assembly);

            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IJobPositionService, JobPositionService>();
            services.AddScoped<ICandidateService, CandidateService>();

            return services;
        }
    }
}
