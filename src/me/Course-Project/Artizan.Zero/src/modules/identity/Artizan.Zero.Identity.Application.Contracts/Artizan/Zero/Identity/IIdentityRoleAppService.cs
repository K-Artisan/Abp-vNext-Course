﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Artizan.Zero.Identity
{
    public interface IIdentityRoleAppService : IApplicationService
    {
        #region OrganizationUnit

        Task<ListResultDto<OrganizationUnitDto>> GetOrganizationUnitsAsync(Guid id);

        Task SetOrganizationUnitsAsync(Guid id, IdentityRoleAddOrRemoveOrganizationUnitDto input);

        Task RemoveOrganizationUnitsAsync(Guid id, Guid ouId);

        #endregion

        #region ClaimType

        Task<ListResultDto<IdentityClaimDto>> GetClaimsAsync(Guid id);

        Task AddClaimAsync(Guid id, IdentityRoleClaimCreateDto input);

        Task UpdateClaimAsync(Guid id, IdentityRoleClaimUpdateDto input);

        Task DeleteClaimAsync(Guid id, IdentityRoleClaimDeleteDto input);

        #endregion
    }
}