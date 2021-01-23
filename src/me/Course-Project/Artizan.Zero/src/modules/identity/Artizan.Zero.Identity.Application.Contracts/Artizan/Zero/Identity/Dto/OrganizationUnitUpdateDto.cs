using Volo.Abp.ObjectExtending;

namespace Artizan.Zero.Identity
{
    public class OrganizationUnitUpdateDto : ExtensibleObject
    {
        public string DisplayName { get; set; }
    }
}
