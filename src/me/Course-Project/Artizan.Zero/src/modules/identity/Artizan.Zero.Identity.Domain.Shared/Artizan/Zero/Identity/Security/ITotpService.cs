using System;
using System.Collections.Generic;
using System.Text;

namespace Artizan.Zero.Identity.Security
{
    /// <summary>
    /// totp算法服务
    /// </summary>
    public interface ITotpService
    {
        int GenerateCode(byte[] securityToken, string modifier = null);

        bool ValidateCode(byte[] securityToken, int code, string modifier = null);
    }
}
