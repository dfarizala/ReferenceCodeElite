using System;
using MedicalClinic.Domain.Pharmacy.Interfaces;
using MedicalClinic.Domain.Pharmacy.Interfaces.Application;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalClinic.Application.Pharmacy
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
            services.AddTransient<IPharmacyApplication, PharmacyApplication>();
            services.AddTransient<IArticleApplication, ArticleApplication>();

            return services;
        }
    }
}
