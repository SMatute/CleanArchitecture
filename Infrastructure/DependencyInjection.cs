using Application.Common.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence (this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("RijsatDatabase"),
            b => b.MigrationsAssembly(typeof(ApplicationDBContext).Assembly.FullName)), ServiceLifetime.Transient);


            services.AddScoped<IApplicationDBContext>(provider => provider.GetService<ApplicationDBContext>());
            return services;

        }

    }
}
