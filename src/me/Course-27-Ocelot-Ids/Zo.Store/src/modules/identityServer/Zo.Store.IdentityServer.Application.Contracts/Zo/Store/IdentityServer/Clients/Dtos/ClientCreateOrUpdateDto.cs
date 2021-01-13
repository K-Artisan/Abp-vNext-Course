using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.IdentityServer.Clients;
using Volo.Abp.Validation;

namespace Zo.Store.IdentityServer.Clients.Dtos
{
    public class ClientCreateOrUpdateDto
    {
        [Required]
        [DynamicStringLength(typeof(ClientConsts), nameof(ClientConsts.ClientIdMaxLength))]
        public string ClientId { get; set; }

        [Required]
        [DynamicStringLength(typeof(ClientConsts), nameof(ClientConsts.ClientNameMaxLength))]
        public string ClientName { get; set; }

        [DynamicStringLength(typeof(ClientConsts), nameof(ClientConsts.DescriptionMaxLength))]
        public string Description { get; set; }

        public List<string> AllowedGrantTypes { get; set; }

        protected ClientCreateOrUpdateDto()
        {
            AllowedGrantTypes = new List<string>();
        }
    }
}
