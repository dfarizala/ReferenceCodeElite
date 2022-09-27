using System.Reflection;
using MediatR;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Infrastructure.Helper.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalClinic.Infrastructure.Security
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Add Infraestructure Services
        /// </summary>
        /// <param name="services">List Service from startup</param>
        /// <param name="configuration">Configuration site</param>
        /// <returns>Updated service list</returns>
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly()); ///Automapper
            services.AddMediatR(Assembly.GetExecutingAssembly()); //Mediator
            services.AddSingleton<IExecutorOrchestrator, ExecutorOrchestrator>();

            return services;
        }
    }
}
