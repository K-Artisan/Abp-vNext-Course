using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Zo.Store.IdentityServer.ApiResources.Dtos;

namespace Zo.Store.IdentityServer.ApiResources
{
    public interface IApiResourceAppService :
        ICrudAppService<
            ApiResourceDto,
            Guid,
            ApiResourceGetByPagedInputDto,
            ApiResourceCreateDto,
            ApiResourceUpdateDto>
    {
    }
}
