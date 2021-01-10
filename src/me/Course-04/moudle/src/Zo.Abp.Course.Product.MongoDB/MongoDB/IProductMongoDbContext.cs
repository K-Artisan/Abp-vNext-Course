using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Zo.Abp.Course.Product.MongoDB
{
    [ConnectionStringName(ProductDbProperties.ConnectionStringName)]
    public interface IProductMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
