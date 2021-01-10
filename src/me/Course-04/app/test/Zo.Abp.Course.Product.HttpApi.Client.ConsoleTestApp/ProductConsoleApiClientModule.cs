using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Zo.Abp.Course.Product.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(ProductHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ProductConsoleApiClientModule : AbpModule
    {
        
    }
}
