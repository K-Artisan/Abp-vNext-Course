using Zo.Store.Identity.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Zo.Store.Identity
{
    public abstract class IdentityController : AbpController
    {
        protected IdentityController()
        {
            LocalizationResource = typeof(IdentityResource);
        }
    }
}
