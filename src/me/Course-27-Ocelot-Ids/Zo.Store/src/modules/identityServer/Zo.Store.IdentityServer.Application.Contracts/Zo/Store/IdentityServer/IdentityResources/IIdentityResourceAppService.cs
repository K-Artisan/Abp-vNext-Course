using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.IdentityServer.IdentityResources;
using Zo.Store.IdentityServer.IdentityResources.Dtos;

namespace Zo.Store.IdentityServer.IdentityResources
{
    public interface IIdentityResourceAppService :
        ICrudAppService<
            IdentityResourceEto,
            Guid,
            IdentityResourceGetByPagedDto,
            IdentityResourceCreateOrUpdateDto,
            IdentityResourceCreateOrUpdateDto
            >
    {
    }
}
