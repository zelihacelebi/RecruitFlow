using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecruitFlow.Application.Interfaces.Repositories;
using RecruitFlow.Infrastructure.Data;
using RecruitFlow.Infrastructure.Repositories;

namespace RecruitFlow.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
           options.UseSqlServer(
               configuration.GetConnectionString("DefaultConnection")
           ));

            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IJobPositionRepository, JobPositionRepository>();
            services.AddScoped<ICandidateRepository, CandidateRepository>();


            return services;
        }
    }
}
