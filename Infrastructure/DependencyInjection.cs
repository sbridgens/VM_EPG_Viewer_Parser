using System;
using System.Collections.Generic;
using System.Text;
using Application.Configuration;
using Application.DataAccess.Persistence.Contracts;
using Application.FileManager.Serialization;
using Infrastructure.DataAccess.Persistence.Contexts;
using Infrastructure.FileManager;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Internal;
using Microsoft.Extensions.Options;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
                options.UseSqlServer(
                    serviceProvider.GetRequiredService<IOptions<DatabaseSettings>>().Value.ConnectionString,
                    builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            
            services.AddScoped<IApplicationDbContext>(provider => 
                provider.GetService<ApplicationDbContext>());

            
            services.AddSingleton<ISystemClock, SystemClock>();
            services.AddSingleton<IXmlSerializationManager, XmlSerializationManager>();

            return services;
        }
    }
}
