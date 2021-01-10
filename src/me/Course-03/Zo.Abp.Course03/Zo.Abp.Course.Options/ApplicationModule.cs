using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Zo.Abp.Course.Options
{
    public class ApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var connectionStringOptions = context.Services.ExecutePreConfiguredActions<ConnectionStringOptions>();
            context.Services.AddDbContext<AppDbContext>(options => {
                options.UseSqlServer(connectionStringOptions.ConnectionString);
            });
        }
    }
}
