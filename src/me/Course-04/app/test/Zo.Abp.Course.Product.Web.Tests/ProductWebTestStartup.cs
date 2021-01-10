using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Zo.Abp.Course.Product
{
    public class ProductWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<ProductWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}