using MedicalClinic.Domain.Website.Interfaces.Application.Security;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalClinic.Application.Invoice
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
