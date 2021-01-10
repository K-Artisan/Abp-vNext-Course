using Zo.Abp.Course.Product.Localization;
using Volo.Abp.Application.Services;

namespace Zo.Abp.Course.Product
{
    public abstract class ProductAppService : ApplicationService
    {
        protected ProductAppService()
        {
            LocalizationResource = typeof(ProductResource);
            ObjectMapperContext = typeof(ProductApplicationModule);
        }
    }
}
