using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Zo.Abp.Course.Product.Data;
using Volo.Abp.DependencyInjection;

namespace Zo.Abp.Course.Product.EntityFrameworkCore
{
    public class EntityFrameworkCoreProductDbSchemaMigrator
        : IProductDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreProductDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ProductMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ProductMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}