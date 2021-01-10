using System;
using Volo.Abp;
using Microsoft.Extensions.DependencyInjection;
using Zo.Abp.Course.Di.Services;

namespace Zo.Abp.Course.Di
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var app = AbpApplicationFactory.Create<AppModule>())
            {
                app.Initialize();

                /*-----------------------------------------------
                 自动注入
                 禁止自动注入
                 手动注入
                 -----------------------------------------------*/
                var userService = app.ServiceProvider.GetService<UserService>();
                var userService2 = app.ServiceProvider.GetService<UserService2>();
                var userService3 = app.ServiceProvider.GetService<UserService3>();

                Console.WriteLine(userService?.SayHello());
                Console.WriteLine($"userService2 is null:{userService2 == null}");
                Console.WriteLine(userService3?.SayHello());

                /*-----------------------------------------------
                 实现接口的所有的实现类都会被注入，
                但是相同的后缀的不会被自动注入，例如：`UserService`, `UserService1`, `UserService2`,只会注入`UserService`
                除非显示注入：
                context.Services.AddTransient<IUserService, UserService3>();
                注入UserService3

                 *-----------------------------------------------*/
                var userServices = app.ServiceProvider.GetServices<IUserService>();
                Console.WriteLine("-------实现接口的所有的实现类都会被注入,----------");
                foreach (var service in userServices)
                {
                    Console.WriteLine(service?.SayHello(null));
                }


                /*-----------------------------------------------
                 生命周期
                -----------------------------------------------*/
                Console.WriteLine("------- 生命周期演示----------");
                for (int i = 0; i < 10; i++)
                {
                    var guidService = app.ServiceProvider.GetService<GuidService>();
                    Console.WriteLine(guidService?.GetId());
                }


                /*-----------------------------------------------
                ExposeServices 特性
                -----------------------------------------------*/
                Console.WriteLine("------- ExposeServices 特性----------");
                var demoExposeService = app.ServiceProvider.GetService<IDemoExposeService>();
                Console.WriteLine(demoExposeService?.GetId());

            }
        }
    }
}
