using System;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalClinic.Infrastructure.Helper
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Add Infraestructure Services
        /// </summary>
        /// <param name="services">List Service from startup</param>
        /// <returns>Updated service list</returns>
        public static IServiceCollection AddInfrastructureHelper(this IServiceCollection services)
        {

            return services;
        }
    }
}
