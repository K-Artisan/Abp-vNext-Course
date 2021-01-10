using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Zo.Abp.Course.Product.EntityFrameworkCore
{
    [ConnectionStringName(ProductDbProperties.ConnectionStringName)]
    public interface IProductDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}