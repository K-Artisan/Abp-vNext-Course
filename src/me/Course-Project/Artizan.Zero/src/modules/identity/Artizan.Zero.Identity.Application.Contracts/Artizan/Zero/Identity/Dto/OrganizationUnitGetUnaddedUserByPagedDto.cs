using Volo.Abp.Application.Dtos;

namespace Artizan.Zero.Identity
{
    public class OrganizationUnitGetUnaddedUserByPagedDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
