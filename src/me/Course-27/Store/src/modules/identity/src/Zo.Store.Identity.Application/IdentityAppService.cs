using Zo.Store.Identity.Localization;
using Volo.Abp.Application.Services;

namespace Zo.Store.Identity
{
    public abstract class IdentityAppService : ApplicationService
    {
        protected IdentityAppService()
        {
            LocalizationResource = typeof(IdentityResource);
            ObjectMapperContext = typeof(IdentityApplicationModule);
        }
    }
}
