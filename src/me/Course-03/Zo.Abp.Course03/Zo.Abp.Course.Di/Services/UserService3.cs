using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.DependencyInjection;
using Zo.Abp.Course.Di.Services;

namespace Zo.Abp.Course.Di.Services
{
    /*
     1. 继承接口ITransientDependency，自动依赖注入
     */

    [DisableConventionalRegistration] //会禁止自动依赖注入
    public class UserService3 : ITransientDependency, IUserService
    {
        public string SayHello(string name = "UserService3")
        {
            return $"Hello {name ?? "UserService3"} !";
        }
    }
}
