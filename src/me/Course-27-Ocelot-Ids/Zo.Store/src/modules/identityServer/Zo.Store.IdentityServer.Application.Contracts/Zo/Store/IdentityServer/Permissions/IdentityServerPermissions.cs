using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Reflection;

namespace Zo.Store.IdentityServer.Permissions
{
    public class IdentityServerPermissions
    {
        public const string GroupName = "IdentityServer";

        public static class Clients
        {
            public const string Default = GroupName + ".Clients";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
            public const string Clone = Default + ".Clone";
            public const string ManagePermissions = Default + ".ManagePermissions";
            public const string ManageClaims = Default + ".ManageClaims";
            public const string ManageSecrets = Default + ".ManageSecrets";
            public const string ManageProperties = Default + ".ManageProperties";
        }

        public static class ApiResources
        {
            public const string Default = GroupName + ".ApiResources";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
            public const string ManageScopes = Default + ".ManageScopes";
            public const string ManageClaims = Default + ".ManageClaims";
            public const string ManageSecrets = Default + ".ManageSecrets";
            public const string ManageProperties = Default + ".ManageProperties";
        }

        public static class IdentityResources
        {
            public const string Default = GroupName + ".IdentityResources";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
            public const string ManageClaims = Default + ".ManageClaims";
            public const string ManageProperties = Default + ".ManageProperties";
        }

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(IdentityServerPermissions));
        }
    }
}
