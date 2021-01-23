using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Artizan.Zero.Identity;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Identity;

namespace Microsoft.AspNetCore.Identity
{
    public static class IdentityUserManagerExtensions
    {
        public static async Task<IdentityResult> SetTwoFactorEnabledWithAccountConfirmedAsync<TUser>(
            [NotNull] this UserManager<TUser> userManager,
            [NotNull] TUser user,
            bool enabled)
            where TUser : class
        {
            Check.NotNull(userManager, nameof(userManager));
            Check.NotNull(user, nameof(user));

            if (enabled)
            {
                var phoneNumberConfirmed = await userManager.IsPhoneNumberConfirmedAsync(user);
                var emailAddressConfirmed = await userManager.IsEmailConfirmedAsync(user);
                // 如果其中一个安全选项未确认,无法启用双因素验证
                if (!phoneNumberConfirmed && !emailAddressConfirmed)
                {
                    // TODO: 返回标准的 IdentityResult
                    //var error = new IdentityError();
                    //return IdentityResult.Failed(error);

                    throw new Artizan.Zero.Identity.IdentityException(
                        Volo.Abp.Identity.IdentityErrorCodes.CanNotChangeTwoFactor,
                        details: phoneNumberConfirmed ? "phone number not confirmed" : "email address not confirmed");
                }
            }

            return await userManager.SetTwoFactorEnabledAsync(user, enabled);
        }
    }
}
