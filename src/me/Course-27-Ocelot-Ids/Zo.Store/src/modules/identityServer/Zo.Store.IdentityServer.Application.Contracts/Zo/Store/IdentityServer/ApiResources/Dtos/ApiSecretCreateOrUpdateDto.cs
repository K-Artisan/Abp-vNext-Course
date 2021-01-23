using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zo.Store.IdentityServer.ApiResources
{
    public class ApiSecretCreateOrUpdateDto : SecretBaseDto
    {
        public HashType HashType { get; set; }
    }
}
