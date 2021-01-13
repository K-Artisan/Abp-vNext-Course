using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Zo.Store.IdentityServer.Clients.Dtos;

namespace Zo.Store.IdentityServer.Clients
{
    public interface IClientAppService :
        ICrudAppService<
            ClientDto,
            Guid,
            ClientGetByPagedDto,
            ClientCreateDto,
            ClientUpdateDto>
    {
        Task<ClientDto> CloneAsync(Guid id, ClientCloneDto input);

        Task<ListResultDto<string>> GetAssignableApiResourcesAsync();

        Task<ListResultDto<string>> GetAssignableIdentityResourcesAsync();

        Task<ListResultDto<string>> GetAllDistinctAllowedCorsOriginsAsync();
    }
}
