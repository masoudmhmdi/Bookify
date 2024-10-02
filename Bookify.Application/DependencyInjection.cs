using Bookify.Domain.Abstractions.Behaviors;
using Bookify.Domain.Bookings;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(configuration =>
            {
                // i do not know how this line of code is work 
                configuration.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly);

                configuration.AddOpenBehavior(typeof(LoggingBehavior<,>));
            });

            services.AddTransient<PricingService>();

            return services;
        }
    }
}
