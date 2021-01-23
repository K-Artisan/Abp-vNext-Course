using Volo.Abp.Application.Dtos;

namespace Artizan.Zero.Identity
{
    public class OrganizationUnitGetByPagedDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
