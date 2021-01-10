using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.DependencyInjection;

namespace Zo.Abp.Course.Di.Services
{
    public class CustomeUserService : ITransientDependency, IUserService
    {
        public string SayHello(string name)
        {
            return $"Hello {name ?? "CustomeUserService"} !";

        }
    }
}
