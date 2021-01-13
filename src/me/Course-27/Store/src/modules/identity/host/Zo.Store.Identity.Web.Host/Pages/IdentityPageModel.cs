using Zo.Store.Identity.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Zo.Store.Identity.Pages
{
    public abstract class IdentityPageModel : AbpPageModel
    {
        protected IdentityPageModel()
        {
            LocalizationResourceType = typeof(IdentityResource);
        }
    }
}