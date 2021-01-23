﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Artizan.Zero.Identity
{
    public interface IIdentityClaimTypeAppService :
        ICrudAppService<
            IdentityClaimTypeDto,
            Guid,
            IdentityClaimTypeGetByPagedDto,
            IdentityClaimTypeCreateDto,
            IdentityClaimTypeUpdateDto>
    {
        Task<ListResultDto<IdentityClaimTypeDto>> GetAllListAsync();
    }
}
