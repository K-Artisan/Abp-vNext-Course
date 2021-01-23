using System;
using System.ComponentModel.DataAnnotations;

namespace Artizan.Zero.Identity
{
    public class IdentityUserOrganizationUnitUpdateDto
    {
        [Required]
        public Guid[] OrganizationUnitIds { get; set; }
    }
}
