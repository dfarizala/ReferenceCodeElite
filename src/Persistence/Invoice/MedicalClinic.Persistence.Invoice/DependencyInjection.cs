using System;
using System.Reflection;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Domain.Invoice.Interfaces;
using MedicalClinic.Domain.Invoice.Interfaces.Persistence;
using MedicalClinic.Persistence.Invoice.Contexts;
using MedicalClinic.Persistence.Invoice.Repository;
using Microsoft.Extensions.Configuration;
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
            services.AddDbContext<InvoiceContext>();
            services.AddTransient<IInvoiceRepository, InvoiceRepository>();
            
            return services;
        }
    }
}
