using Zo.Abp.Course.Product.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Zo.Abp.Course.Product.Pages
{
    public abstract class ProductPageModel : AbpPageModel
    {
        protected ProductPageModel()
        {
            LocalizationResourceType = typeof(ProductResource);
        }
    }
}