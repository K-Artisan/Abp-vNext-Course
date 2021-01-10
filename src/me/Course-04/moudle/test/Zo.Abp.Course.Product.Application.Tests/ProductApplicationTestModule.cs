using Volo.Abp.Modularity;

namespace Zo.Abp.Course.Product
{
    [DependsOn(
        typeof(ProductApplicationModule),
        typeof(ProductDomainTestModule)
        )]
    public class ProductApplicationTestModule : AbpModule
    {

    }
}
