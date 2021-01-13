using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.IdentityServer;
using Volo.Abp.Modularity;

namespace Zo.Store.IdentityServer
{
    [DependsOn(typeof(AbpIdentityServerDomainModule))]
    public class IdentityServerDomainModule
    {

    }
}
