using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Volo.Abp.Identity;

namespace Artizan.Zero.Identity
{
    public class AbpIdentityApplicationModuleAutoMapperProfile : Profile
    {
        public AbpIdentityApplicationModuleAutoMapperProfile()
        {
            CreateMap<IdentityClaimType, IdentityClaimTypeDto>()
                .MapExtraProperties();
            CreateMap<IdentityUserClaim, IdentityClaimDto>();
            CreateMap<IdentityRoleClaim, IdentityClaimDto>();

            CreateMap<IdentityUser, IdentityUserDto>()
                .MapExtraProperties();

            CreateMap<IdentityRole, IdentityRoleDto>()
                .MapExtraProperties();

            CreateMap<OrganizationUnit, OrganizationUnitDto>()
                .MapExtraProperties();
        }
    }
}
