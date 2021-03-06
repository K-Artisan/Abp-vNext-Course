﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Artizan.Zero.Identity
{
    [DependsOn(
        typeof(Volo.Abp.Identity.AbpIdentityApplicationContractsModule),
        typeof(AbpIdentityDomainSharedModule),
        typeof(AbpAuthorizationModule),
        typeof(AbpDddApplicationModule)
        )]
    public class AbpIdentityApplicationContractsModule : AbpModule
    {
    }
}
