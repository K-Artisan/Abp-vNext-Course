using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.IdentityServer.Localization;

namespace Zo.Store.IdentityServer
{
    public abstract class IdentityServerAppServiceBase : ApplicationService
    {
        private IPermissionChecker _permissionChecker;
        protected IPermissionChecker PermissionChecker => LazyGetRequiredService(ref _permissionChecker);
        protected IdentityServerAppServiceBase()
        {
            LocalizationResource = typeof(AbpIdentityServerResource);
        }

        protected virtual async Task<bool> IsGrantAsync(string policy)
        {
            return await PermissionChecker.IsGrantedAsync(policy);
        }
    }
}
