using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainAPI.Configuration
{
    public static class ConfigureHealthChecks
    {
        public static IServiceCollection AddCustomHealthChecks(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddHealthChecks()
                .AddSqlServer(configuration.GetConnectionString("MyDatabase"),
                    name: "MyDatabase-Check",
                    tags: new string[] { "MyDatabase" });

            return services;
        }
    }
}
