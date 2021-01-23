using Volo.Abp.Application.Dtos;

namespace Artizan.Zero.Identity
{
    public class OrganizationUnitGetUnaddedRoleByPagedDto : PagedAndSortedResultRequestDto
    {

        public string Filter { get; set; }
    }
}
