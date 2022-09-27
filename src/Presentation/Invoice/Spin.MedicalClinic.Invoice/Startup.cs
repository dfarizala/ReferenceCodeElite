using System;
using System.Diagnostics;
using MedicalClinic.Application.Invoice;
using MedicalClinic.Domain.Invoice.Entities.Information;
using MedicalClinic.Infrastructure.Invoice;
using MedicalClinic.Persistence.Invoice;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Spin.Base.Extend.Observer;
using Spin.Base.Helper.Base;
using Spin.Base.Helper.Company;
using Spin.Diagnostics.API.DiagnosticLog.Providers.Console;
using Spin.Diagnostics.Entity.DiagnosticLog;
using Spin.Helper.Injection;
using Spin.MedicalClinic.Invoice;

namespace Spin.WebSite
{
    public class Startup : SpinStartup
    {
        //public override ISpinProgramConfiguration SpinHost { get { return new SpinProgramApiConfiguration(); } }

        #region Startup
        public Startup(IConfiguration configuration)
            : base(configuration, new ClinicalInvoiceInformation())
        {
            this.AddProviderDiagnosticLog(new ConsoleProviderDiagnostics(TypeMessage.Error));
             this.SpinSwagger.Enabled = true;

        }
        #endregion


        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var groupName = "v" + CompanyFactory.Information.Version;

                options.SwaggerDoc(groupName, new OpenApiInfo
                {
                    Title = $"Medical Invoice {groupName}",
                    Version = groupName,
                    Description = "Medical API Invoice information, made by medical developer team",
                    TermsOfService = new Uri("https://www.medical.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Medical",
                        Email = string.Empty,
                        Url = new Uri("https://www.medical.com/"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new Uri("https://www.medical.com/license"),
                    }
                });

                //Add Assemblies Documentation Files
                /*
                foreach (var FileItem in Folder.GetFiles("", "xml"))
                {
                    if (FileItem.Name.StartsWith("Medical.") || FileItem.Name.StartsWith("Spin.Medical."))
                    {
                        options.IncludeXmlComments(FileItem.FullName);
                    }
                }
                */
            });


            services.AddApplication();
            services.AddPersistence();
            services.AddInfrastructure();

            base.ConfigureServices(services);
        }


        public override void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IMemoryCache cache, DiagnosticListener diagnosticListenerSource, DiagnosticObserverSpin diagnosticObserver)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint($"/swagger/v{CompanyFactory.Information.Version}/swagger.json", $"Medical API V{CompanyFactory.Information.Version}");
                });
            }

            base.Configure(app, env, loggerFactory, cache, diagnosticListenerSource, diagnosticObserver);
        }


        public override void ConfigureServiceSpin(SpinServiceCollection Service)
        {
            base.ConfigureServiceSpin(Service);
        }
    }

}
