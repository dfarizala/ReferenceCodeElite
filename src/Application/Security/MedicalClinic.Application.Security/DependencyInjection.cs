using MedicalClinic.Application.Security.Services;
using MedicalClinic.Domain.Security.Interfaces.Application;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalClinic.Application.Security
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Add Infraestructure Services
        /// </summary>
        /// <param name="services">List Service from startup</param>
        /// <param name="configuration">Configuration site</param>
        /// <returns>Updated service list</returns>
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IUserApplication, UserApplication>();

            return services;
        }
    }
}
