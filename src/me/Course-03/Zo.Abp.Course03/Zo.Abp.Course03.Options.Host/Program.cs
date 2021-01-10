using System;
using Volo.Abp;
using Zo.Abp.Course.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Zo.Abp.Course03.Options.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var app = AbpApplicationFactory.Create<HostModule>())
            {
                app.Initialize();

                var db = app.ServiceProvider.GetService<AppDbContext>();
                Console.WriteLine(db.Database.GetDbConnection().ConnectionString);
            }
        }
    }
}
