﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Zo.Store.IdentityServer.ApiResources.Dtos
{
    public class ApiResourceDto : ExtensibleFullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public bool Enabled { get; set; }

        public List<ApiSecretDto> Secrets { get; set; }

        public List<ApiScopeDto> Scopes { get; set; }

        public List<string> UserClaims { get; set; }

        public Dictionary<string, string> Properties { get; set; }

        public ApiResourceDto()
        {
            UserClaims = new List<string>();
            Scopes = new List<ApiScopeDto>();
            Secrets = new List<ApiSecretDto>();
            Properties = new Dictionary<string, string>();
        }
    }
}
