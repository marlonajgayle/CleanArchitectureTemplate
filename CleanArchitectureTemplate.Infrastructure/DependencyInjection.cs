using CleanArchitectureTemplate.Application.Common.Interfaces;
using CleanArchitectureTemplate.Infrastructure.Identity;
using CleanArchitectureTemplate.Infrastructure.Persistence;
using CleanArchitectureTemplate.Infrastructure.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureTemplate.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
           IConfiguration configuration, IWebHostEnvironment environment)
        {
            // Register Services 
            services.AddTransient<IMailService, MailService>();

            services.AddDbContextPool<InvestEdgeDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("InvestEdgeDbConnection")));

            services.AddScoped<IInvestEdgeDbContext>(provider => provider.GetService<InvestEdgeDbContext>());

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 3;
                options.Password.RequireDigit = true;
                options.Password.RequireUppercase = true;
            }).AddEntityFrameworkStores<InvestEdgeDbContext>();



            return services;
        }
    }
}
