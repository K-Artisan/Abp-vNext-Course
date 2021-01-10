using System.Threading.Tasks;

namespace Zo.Abp.Course.Product.Data
{
    public interface IProductDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
