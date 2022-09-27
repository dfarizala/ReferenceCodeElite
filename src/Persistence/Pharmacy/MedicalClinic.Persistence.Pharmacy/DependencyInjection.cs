using System;
using System.Reflection;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Domain.Pharmacy.Interfaces.Persistence;
using MedicalClinic.Persistence.Pharmacy.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalClinic.Persistence.Pharmacy
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
            services.AddScoped<IArticleContext, ArticleContext>();
            services.AddScoped<IBatchContext, BatchContext>();
            services.AddScoped<IConceptContext, ConceptContext>();
            services.AddScoped<IStockContext, StockContext>();
            services.AddScoped<IStorageContext, StorageContext>();

            return services;
        }
    }
}
