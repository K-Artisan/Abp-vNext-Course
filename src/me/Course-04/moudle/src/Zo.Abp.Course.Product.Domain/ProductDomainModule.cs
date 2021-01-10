using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Zo.Abp.Course.Product
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(ProductDomainSharedModule)
    )]
    public class ProductDomainModule : AbpModule
    {

    }
}
