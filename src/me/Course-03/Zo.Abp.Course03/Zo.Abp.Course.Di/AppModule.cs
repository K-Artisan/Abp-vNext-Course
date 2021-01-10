using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
using Zo.Abp.Course.Di.Services;

namespace Zo.Abp.Course.Di
{
    public class AppModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            //SkipAutoServiceRegistration = true; //,禁用依照约定的注册 
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //context.Services.AddTransient<UserService3>();
            context.Services.AddTransient<IUserService, UserService3>();

        }
    }
}
