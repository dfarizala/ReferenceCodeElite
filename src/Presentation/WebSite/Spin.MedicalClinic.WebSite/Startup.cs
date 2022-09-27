using MedicalClinic.Application.Invoice;
using MedicalClinic.Infrastructure.Invoice;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Spin.Base.Helper.Base;
using Spin.Diagnostics.API.DiagnosticLog.Providers.Console;
using Spin.Diagnostics.Entity.DiagnosticLog;
using Spin.Helper.Injection;
using Spin.Helper.Session.Base;
using Spin.Themes.API;

namespace Spin.WebSite
{
    public class Startup: SpinStartup
    {
        #region Startup
        public Startup(IConfiguration configuration)
            :base(configuration)
        {
            this.AddProviderDiagnosticLog(new ConsoleProviderDiagnostics(TypeMessage.Error));


            this.SpinSwagger.Enabled = true;
            
        }
        #endregion


        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication();
            services.AddInfrastructure();
            base.ConfigureServices(services);
        }



        public override void ConfigureServiceSpin(SpinServiceCollection Service)
        {
            
            base.ConfigureServiceSpin(Service);
        }
    }

}
