using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Applicaion;

public static  class ApplicationServiceRegistration // Inversion Of Container IoC
{
    public static IServiceCollection ApplicationServiceExtensionsIoC(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()); // handler rol oynuyor dikkat 
        });

        return services;
    }
}
