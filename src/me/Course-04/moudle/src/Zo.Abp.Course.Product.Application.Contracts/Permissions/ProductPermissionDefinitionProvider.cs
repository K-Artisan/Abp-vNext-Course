﻿using Zo.Abp.Course.Product.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Zo.Abp.Course.Product.Permissions
{
    public class ProductPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ProductPermissions.GroupName, L("Permission:Product"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ProductResource>(name);
        }
    }
}