using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Zo.Store.IdentityServer.Clients
{
    public class ClientGetByPagedDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
