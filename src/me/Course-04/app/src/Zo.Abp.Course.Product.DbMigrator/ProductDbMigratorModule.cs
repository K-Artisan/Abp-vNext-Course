using Zo.Abp.Course.Product.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Zo.Abp.Course.Product.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ProductEntityFrameworkCoreDbMigrationsModule),
        typeof(ProductApplicationContractsModule)
        )]
    public class ProductDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
