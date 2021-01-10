using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Zo.Abp.Course.Product.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ProductMigrationsDbContextFactory : IDesignTimeDbContextFactory<ProductMigrationsDbContext>
    {
        public ProductMigrationsDbContext CreateDbContext(string[] args)
        {
            ProductEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ProductMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new ProductMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Zo.Abp.Course.Product.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
