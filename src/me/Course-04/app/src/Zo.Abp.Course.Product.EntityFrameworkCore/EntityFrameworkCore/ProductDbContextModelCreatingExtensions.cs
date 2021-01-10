using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Zo.Abp.Course.Product.EntityFrameworkCore
{
    public static class ProductDbContextModelCreatingExtensions
    {
        public static void ConfigureProduct(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ProductConsts.DbTablePrefix + "YourEntities", ProductConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

        }
    }
}