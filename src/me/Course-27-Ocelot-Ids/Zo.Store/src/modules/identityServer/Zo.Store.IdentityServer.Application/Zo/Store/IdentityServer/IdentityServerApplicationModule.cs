using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Zo.Store.IdentityServer
{
    [DependsOn(
        typeof(IdentityServerDomainModule),
        typeof(IdentityServerApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class IdentityServerApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<IdentityServerApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.Configurators.Add(ctx =>
                {
                    ctx.MapperConfiguration.AddProfile<IdentityServerApplicationAutoMapperProfile>();
                });
            });

        }
    }
}