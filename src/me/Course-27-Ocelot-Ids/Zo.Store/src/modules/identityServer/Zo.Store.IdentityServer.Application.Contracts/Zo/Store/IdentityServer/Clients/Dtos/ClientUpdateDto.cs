using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.IdentityServer.Clients;
using Volo.Abp.Validation;

namespace Zo.Store.IdentityServer.Clients
{
    public class ClientUpdateDto : ClientCreateOrUpdateDto
    {

        [DynamicStringLength(typeof(ClientConsts), nameof(ClientConsts.ClientUriMaxLength))]
        public string ClientUri { get; set; }

        [DynamicStringLength(typeof(ClientConsts), nameof(ClientConsts.ClientUriMaxLength))]
        public string LogoUri { get; set; }

        public bool Enabled { get; set; }

        [DynamicStringLength(typeof(ClientConsts), nameof(ClientConsts.ProtocolTypeMaxLength))]
        public string ProtocolType { get; set; }

        public bool RequireClientSecret { get; set; }

        public bool RequireConsent { get; set; }

        public bool AllowRememberConsent { get; set; }

        public bool AlwaysIncludeUserClaimsInIdToken { get; set; }

        public bool RequirePkce { get; set; }

        public bool AllowPlainTextPkce { get; set; }

        public bool AllowAccessTokensViaBrowser { get; set; }

        [DynamicStringLength(typeof(ClientConsts), nameof(ClientConsts.FrontChannelLogoutUriMaxLength))]
        public string FrontChannelLogoutUri { get; set; }

        public bool FrontChannelLogoutSessionRequired { get; set; }

        [DynamicStringLength(typeof(ClientConsts), nameof(ClientConsts.BackChannelLogoutUriMaxLength))]
        public string BackChannelLogoutUri { get; set; }

        public bool BackChannelLogoutSessionRequired { get; set; }

        public bool AllowOfflineAccess { get; set; }

        public int IdentityTokenLifetime { get; set; }

        public int AccessTokenLifetime { get; set; }

        public int AuthorizationCodeLifetime { get; set; }

        public int? ConsentLifetime { get; set; }

        public int AbsoluteRefreshTokenLifetime { get; set; }

        public int SlidingRefreshTokenLifetime { get; set; }

        public int RefreshTokenUsage { get; set; }

        public bool UpdateAccessTokenClaimsOnRefresh { get; set; }

        public int RefreshTokenExpiration { get; set; }

        public int AccessTokenType { get; set; }

        public bool EnableLocalLogin { get; set; }

        public bool IncludeJwtId { get; set; }

        public bool AlwaysSendClientClaims { get; set; }

        [DynamicStringLength(typeof(ClientConsts), nameof(ClientConsts.ClientClaimsPrefixMaxLength))]

        public string ClientClaimsPrefix { get; set; }

        [DynamicStringLength(typeof(ClientConsts), nameof(ClientConsts.PairWiseSubjectSaltMaxLength))]

        public string PairWiseSubjectSalt { get; set; }

        public int? UserSsoLifetime { get; set; }

        [DynamicStringLength(typeof(ClientConsts), nameof(ClientConsts.UserCodeTypeMaxLength))]

        public string UserCodeType { get; set; }

        public int DeviceCodeLifetime { get; set; }
        /// <summary>
        /// 允许的作用域
        /// </summary>
        public List<string> AllowedScopes { get; set; }
        /// <summary>
        /// 允许同源
        /// </summary>
        public List<string> AllowedCorsOrigins { get; set; }
        /// <summary>
        /// 重定向uri
        /// </summary>
        public List<string> RedirectUris { get; set; }
        /// <summary>
        /// 登出重定向uri
        /// </summary>
        public List<string> PostLogoutRedirectUris { get; set; }
        /// <summary>
        /// 限制提供商
        /// </summary>
        public List<string> IdentityProviderRestrictions { get; set; }
        /// <summary>
        /// 属性
        /// </summary>
        public Dictionary<string, string> Properties { get; set; }
        /// <summary>
        /// 密钥
        /// </summary>
        public List<SecretCreateOrUpdateDto> Secrets { get; set; }
        /// <summary>
        /// 声明
        /// </summary>
        public List<ClientClaimDto> Claims { get; set; }

        public ClientUpdateDto()
        {
            Enabled = true;
            DeviceCodeLifetime = 300;
            AllowedScopes = new List<string>();
            RedirectUris = new List<string>();
            AllowedCorsOrigins = new List<string>();
            PostLogoutRedirectUris = new List<string>();
            IdentityProviderRestrictions = new List<string>();
            Properties = new Dictionary<string, string>();
            Secrets = new List<SecretCreateOrUpdateDto>();
            Claims = new List<ClientClaimDto>();
        }
    }
}
