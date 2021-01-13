using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zo.Store.IdentityServer.ApiResources
{
    public interface IApiResourceRepository : Volo.Abp.IdentityServer.ApiResources.IApiResourceRepository
    {
        Task<List<string>> GetNamesAsync(CancellationToken cancellationToken = default);
    }
}
