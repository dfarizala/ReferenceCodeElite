using MedicalClinic.Domain.LogsImhotep.Interfaces.Persistence;
using MedicalClinic.Persistence.LogsImhotep.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalClinic.Persistence.Invoice
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Add Infraestructure Services
        /// </summary>
        /// <param name="services">List Service from startup</param>
        /// <param name="configuration">Configuration site</param>
        /// <returns>Updated service list</returns>
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddScoped<ILogImothepContext, LogImothepContext>();

            return services;
        }
    }
}
