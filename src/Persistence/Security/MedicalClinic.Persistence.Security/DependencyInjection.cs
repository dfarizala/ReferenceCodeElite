using MedicalClinic.Domain.Security.Interfaces.Persistence;
using MedicalClinic.Persistence.Security.Contexts;
using MedicalClinic.Persistence.Security.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalClinic.Persistence.Security
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
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddDbContext<UserContext>();

            return services;
        }
    }
}
