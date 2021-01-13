using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.IdentityServer.Localization;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Zo.Store.IdentityServer.Permissions
{
    public class IdentityServerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var identityServerGroup = context.GetGroupOrNull(IdentityServerPermissions.GroupName);
            if (identityServerGroup == null)
            {
                identityServerGroup = context
                    .AddGroup(
                        name: IdentityServerPermissions.GroupName,
                        displayName: L("Permissions:IdentityServer"),
                        multiTenancySide: MultiTenancySides.Host);
            }
            // 客户端权限
            var clientPermissions = identityServerGroup.AddPermission(IdentityServerPermissions.Clients.Default, L("Permissions:Clients"), MultiTenancySides.Host);
            clientPermissions.AddChild(IdentityServerPermissions.Clients.Create, L("Permissions:Create"), MultiTenancySides.Host);
            clientPermissions.AddChild(IdentityServerPermissions.Clients.Update, L("Permissions:Update"), MultiTenancySides.Host);
            clientPermissions.AddChild(IdentityServerPermissions.Clients.Clone, L("Permissions:Clone"), MultiTenancySides.Host);
            clientPermissions.AddChild(IdentityServerPermissions.Clients.Delete, L("Permissions:Delete"), MultiTenancySides.Host);
            clientPermissions.AddChild(IdentityServerPermissions.Clients.ManagePermissions, L("Permissions:ManagePermissions"), MultiTenancySides.Host);
            clientPermissions.AddChild(IdentityServerPermissions.Clients.ManageClaims, L("Permissions:ManageClaims"), MultiTenancySides.Host);
            clientPermissions.AddChild(IdentityServerPermissions.Clients.ManageSecrets, L("Permissions:ManageSecrets"), MultiTenancySides.Host);
            clientPermissions.AddChild(IdentityServerPermissions.Clients.ManageProperties, L("Permissions:ManageProperties"), MultiTenancySides.Host);

            // Api资源权限
            var apiResourcePermissions = identityServerGroup.AddPermission(IdentityServerPermissions.ApiResources.Default, L("Permissions:ApiResources"), MultiTenancySides.Host);
            apiResourcePermissions.AddChild(IdentityServerPermissions.ApiResources.Create, L("Permissions:Create"), MultiTenancySides.Host);
            apiResourcePermissions.AddChild(IdentityServerPermissions.ApiResources.Update, L("Permissions:Update"), MultiTenancySides.Host);
            apiResourcePermissions.AddChild(IdentityServerPermissions.ApiResources.Delete, L("Permissions:Delete"), MultiTenancySides.Host);
            apiResourcePermissions.AddChild(IdentityServerPermissions.ApiResources.ManageClaims, L("Permissions:ManageClaims"), MultiTenancySides.Host);
            apiResourcePermissions.AddChild(IdentityServerPermissions.ApiResources.ManageSecrets, L("Permissions:ManageSecrets"), MultiTenancySides.Host);
            apiResourcePermissions.AddChild(IdentityServerPermissions.ApiResources.ManageProperties, L("Permissions:ManageProperties"), MultiTenancySides.Host);
            apiResourcePermissions.AddChild(IdentityServerPermissions.ApiResources.ManageScopes, L("Permissions:ManageScopes"), MultiTenancySides.Host);

            // 身份资源权限
            var identityResourcePermissions = identityServerGroup.AddPermission(IdentityServerPermissions.IdentityResources.Default, L("Permissions:IdentityResources"), MultiTenancySides.Host);
            identityResourcePermissions.AddChild(IdentityServerPermissions.IdentityResources.Create, L("Permissions:Create"), MultiTenancySides.Host);
            identityResourcePermissions.AddChild(IdentityServerPermissions.IdentityResources.Update, L("Permissions:Update"), MultiTenancySides.Host);
            identityResourcePermissions.AddChild(IdentityServerPermissions.IdentityResources.Delete, L("Permissions:Delete"), MultiTenancySides.Host);
            identityResourcePermissions.AddChild(IdentityServerPermissions.IdentityResources.ManageClaims, L("Permissions:ManageClaims"), MultiTenancySides.Host);
            identityResourcePermissions.AddChild(IdentityServerPermissions.IdentityResources.ManageProperties, L("Permissions:ManageProperties"), MultiTenancySides.Host);
        }


        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpIdentityServerResource>(name);
        }
    }
}
