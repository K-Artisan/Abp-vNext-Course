using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Artizan.Zero.Identity.EntityFrameworkCore
{
    [DependsOn(typeof(Artizan.Zero.Identity.AbpIdentityDomainModule))]
    [DependsOn(typeof(Volo.Abp.Identity.EntityFrameworkCore.AbpIdentityEntityFrameworkCoreModule))]
    public class AbpIdentityEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<IdentityDbContext>(options =>
            {
                options.AddRepository<IdentityRole, EfCoreIdentityRoleRepository>();
                options.AddRepository<IdentityUser, EfCoreIdentityUserRepository>();
            });
        }
    }
}
