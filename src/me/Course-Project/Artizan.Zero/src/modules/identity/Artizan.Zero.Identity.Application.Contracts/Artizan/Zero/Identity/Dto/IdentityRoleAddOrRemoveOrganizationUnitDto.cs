using System;
using System.ComponentModel.DataAnnotations;

namespace Artizan.Zero.Identity
{
    public class IdentityRoleAddOrRemoveOrganizationUnitDto
    {
        [Required]
        public Guid[] OrganizationUnitIds { get; set; }
    }
}
