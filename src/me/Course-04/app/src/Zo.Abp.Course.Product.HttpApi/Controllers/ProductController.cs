using Zo.Abp.Course.Product.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Zo.Abp.Course.Product.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ProductController : AbpController
    {
        protected ProductController()
        {
            LocalizationResource = typeof(ProductResource);
        }
    }
}