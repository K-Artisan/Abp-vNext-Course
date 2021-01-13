using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Zo.Store.Identity
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(IdentityDomainSharedModule)
    )]
    public class IdentityDomainModule : AbpModule
    {

    }
}
