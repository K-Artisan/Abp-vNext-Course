using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Zo.Store.IdentityServer.EntityFrameworkCore
{
    [DependsOn(typeof(IdentityServerDomainModule))]
    [DependsOn(typeof(AbpIdentityServerEntityFrameworkCoreModule))]
    public class IdentityServerEntityFrameworkCoreModule : AbpModule
    {

    }
}
