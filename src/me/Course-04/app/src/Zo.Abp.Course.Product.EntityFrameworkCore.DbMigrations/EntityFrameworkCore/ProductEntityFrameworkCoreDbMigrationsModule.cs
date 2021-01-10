using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Zo.Abp.Course.Product.EntityFrameworkCore
{
    [DependsOn(
        typeof(ProductEntityFrameworkCoreModule)
        )]
    public class ProductEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ProductMigrationsDbContext>();
        }
    }
}
