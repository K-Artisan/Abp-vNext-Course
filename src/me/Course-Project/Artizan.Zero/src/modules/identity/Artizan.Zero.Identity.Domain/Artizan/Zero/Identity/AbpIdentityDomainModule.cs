using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Artizan.Zero.Identity
{
    [DependsOn(
        typeof(AbpIdentityDomainSharedModule),
        typeof(Volo.Abp.Identity.AbpIdentityDomainModule))]
    public class AbpIdentityDomainModule : AbpModule
    {
    }
}
