using Zo.Abp.Course.Product.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Zo.Abp.Course.Product.Permissions
{
    public class ProductPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ProductPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ProductPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ProductResource>(name);
        }
    }
}
