using Zo.Abp.Course.Product.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Zo.Abp.Course.Product.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ProductPageModel : AbpPageModel
    {
        protected ProductPageModel()
        {
            LocalizationResourceType = typeof(ProductResource);
        }
    }
}