using Zo.Abp.Course.Product.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Zo.Abp.Course.Product
{
    [DependsOn(
        typeof(ProductEntityFrameworkCoreTestModule)
        )]
    public class ProductDomainTestModule : AbpModule
    {

    }
}