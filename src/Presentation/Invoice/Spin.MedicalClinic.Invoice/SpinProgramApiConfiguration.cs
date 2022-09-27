using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using Spin.Base.Helper.Base;
using Spin.Helper.Injection;
using Spin.WebSite;

namespace Spin.MedicalClinic.Invoice
{
    public class SpinProgramApiConfiguration: SpinProgram<Startup>, ISpinProgramConfiguration
    {
        public void Run<T>() 
           where T : SpinStartup
        {
            var host = CreateHostBuilder<T>(Array.Empty<string>()).Build();
            SpinServiceCollection.LoadProvider(host.Services);
            host.Run();
        }

        protected virtual IHostBuilder CreateHostBuilder<T>(string[] args)
            where T : SpinStartup
            =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog((ctx, cfg) =>
                {
                    cfg.MinimumLevel.Verbose()
                       .Enrich.WithProperty("ApplicationContext", "aaa")
                       .Enrich.FromLogContext()
                       .WriteTo.Console()
                       .ReadFrom.Configuration(ctx.Configuration);
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<T>();
                });
    }
}
