﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.IdentityServer.IdentityResources;
using Volo.Abp.Validation;

namespace Zo.Store.IdentityServer.IdentityResources.Dtos
{
    public class IdentityResourceCreateOrUpdateDto
    {
        [Required]
        [DynamicStringLength(typeof(IdentityResourceConsts), nameof(IdentityResourceConsts.NameMaxLength))]
        public string Name { get; set; }

        [DynamicStringLength(typeof(IdentityResourceConsts), nameof(IdentityResourceConsts.DisplayNameMaxLength))]
        public string DisplayName { get; set; }

        [DynamicStringLength(typeof(IdentityResourceConsts), nameof(IdentityResourceConsts.DescriptionMaxLength))]
        public string Description { get; set; }

        public bool Enabled { get; set; }

        public bool Required { get; set; }

        public bool Emphasize { get; set; }

        public bool ShowInDiscoveryDocument { get; set; }

        public List<string> UserClaims { get; set; }

        public Dictionary<string, string> Properties { get; set; }

        public IdentityResourceCreateOrUpdateDto()
        {
            UserClaims = new List<string>();
            Properties = new Dictionary<string, string>();

            Enabled = true;
            Required = false;
            ShowInDiscoveryDocument = false;
        }
    }
}
