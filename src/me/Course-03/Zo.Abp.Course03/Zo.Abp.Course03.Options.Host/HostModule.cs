using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;
using Zo.Abp.Course.Options;

namespace Zo.Abp.Course03.Options.Host
{
    [DependsOn(typeof(ApplicationModule))]
    public class HostModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.PreConfigure<ConnectionStringOptions>(options =>
            {
                options.ConnectionString = "Data Source=.; Initial Catalog=AbpDb; User ID=sa; Password=******;";
            });
        }
    }
}
