﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zo.Store.IdentityServer
{
    public class IdentityServerErrorConsts
    {
        /// <summary>
        /// 客户端标识已经存在
        /// </summary>
        public const string ClientIdExisted = "ClientIdExisted";

        /// <summary>
        /// Api资源已经存在
        /// </summary>
        public const string ApiResourceNameExisted = "ApiResourceNameExisted";

        /// <summary>
        /// 身份资源已经存在
        /// </summary>
        public const string IdentityResourceNameExisted = "IdentityResourceNameExisted";

        /// <summary>
        /// 身份资源属性已经存在
        /// </summary>
        public const string IdentityResourcePropertyExisted = "IdentityResourcePropertyExisted";

        /// <summary>
        /// 客户端声明不存在
        /// </summary>
        public const string ClientClaimNotFound = "ClientClaimNotFound";

        /// <summary>
        /// 客户端密钥不存在
        /// </summary>
        public const string ClientSecretNotFound = "ClientSecretNotFound";

        /// <summary>
        /// 客户端属性不存在
        /// </summary>
        public const string ClientPropertyNotFound = "ClientPropertyNotFound";

        /// <summary>
        /// 身份资源属性不存在
        /// </summary>
        public const string IdentityResourcePropertyNotFound = "IdentityResourcePropertyNotFound";
    }
}
