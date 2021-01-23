using Volo.Abp.Application.Dtos;

namespace Artizan.Zero.Identity
{
    public class IdentityClaimTypeGetByPagedDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
