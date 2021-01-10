using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.DependencyInjection;

namespace Zo.Abp.Course.Di.Services
{
    /*
     1. 继承接口ITransientDependency，自动依赖注入
     */
 
    public class UserService : ITransientDependency, IUserService
    {
        public string SayHello(string name = "UserService")
        {
            return $"Hello {name?? "UserService"} !";
        }
    }
}
