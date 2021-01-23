using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.IdentityServer.ApiResources;
using Volo.Abp.Validation;

namespace Zo.Store.IdentityServer.ApiResources
{
    public class ApiResourceCreateDto : ApiResourceCreateOrUpdateDto
    {
        [Required]
        [DynamicStringLength(typeof(ApiResourceConsts), nameof(ApiResourceConsts.NameMaxLength))]
        public string Name { get; set; }
    }
}
