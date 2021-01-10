using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Zo.Abp.Course.Product.EntityFrameworkCore
{
    public class ProductModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ProductModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}