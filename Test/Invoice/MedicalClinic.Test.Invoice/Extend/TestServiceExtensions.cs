using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
/*
using Microsoft.Extensions.Logging;
using Moq;

namespace MedicalClinic.Test.Invoice.Extend
{
    public class TestServiceExtensions
    {
        /// <summary>
        /// Add all services requires (Application and Infrastructure layer).
        /// </summary>
        /// <returns>Service Provider</returns>
        public static ServiceCollection AddServices()
        {
            var services = new ServiceCollection();
            //Weelo.Application.Security.ServiceExtensions.AddApplicationLayer(services);
            var assemblyValidator = AppDomain.CurrentDomain.Load("MedicalClinic.Infrastructure.Invoice");
            services.AddAutoMapper(assemblyValidator);
            services.AddMediatR(assemblyValidator);
            
            

            //services.AddSingleton<ILogger<InsertOrUpdateCommandHandler>>(mocks_general.Object);
            
            
            /*
            List<User> countries = new List<User>();
            IQueryable<User> queryableCountries = countries.AsQueryable();
            var mock = new Mock<ISecurityUserBL>();
            mock.Setup(c => c.SelectComplex(It.IsAny<int>())).Returns(new User());
            mock.Setup(c => c.InsertOrUpdate(It.IsAny<User>())).Returns(new User());
            mock.Setup(c => c.SelectBy(It.IsAny<Expression<Func<User, bool>>>())).Returns(queryableCountries);

            services.AddSingleton<ISecurityUserBL>(mock.Object);

            #endregion Repository Mock
            */
            /*
            return services;
        }

        public static IMediator BuildMediator(ServiceCollection services)
        {
            var provider = services.BuildServiceProvider();

            return provider.GetRequiredService<IMediator>();
        }

    }
}
*/