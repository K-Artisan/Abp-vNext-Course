﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.IdentityServer.ApiResources;
using Volo.Abp.Validation;
//using Volo.Abp.IdentityServer.ApiResources;

namespace Zo.Store.IdentityServer.ApiResources
{
    public class ApiResourceCreateOrUpdateDto
    {
        [DynamicStringLength(typeof(ApiResourceConsts), nameof(ApiResourceConsts.DisplayNameMaxLength))]

        public string DisplayName { get; set; }
        [DynamicStringLength(typeof(ApiResourceConsts), nameof(ApiResourceConsts.DisplayNameMaxLength))]

        public string Description { get; set; }

        public bool Enabled { get; set; }

        public List<string> UserClaims { get; set; }

        public List<ApiScopeDto> Scopes { get; set; }

        public List<ApiSecretCreateOrUpdateDto> Secrets { get; set; }

        public Dictionary<string, string> Properties { get; set; }

        protected ApiResourceCreateOrUpdateDto()
        {
            UserClaims = new List<string>();
            Scopes = new List<ApiScopeDto>();
            Secrets = new List<ApiSecretCreateOrUpdateDto>();
            Properties = new Dictionary<string, string>();
        }
    }
}
