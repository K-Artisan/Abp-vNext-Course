using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.DependencyInjection;

namespace Zo.Abp.Course.Di.Services
{
    /*
     1. 继承接口ITransientDependency，自动依赖注入
     */

    // [DisableConventionalRegistration] //会禁止自动依赖注入,需要手动注入
    public class UserService2 : ITransientDependency, IUserService
    {
        public string SayHello(string name = "UserService2")
        {
            return $"Hello {name ?? "UserService2"} !";

        }
    }
}
