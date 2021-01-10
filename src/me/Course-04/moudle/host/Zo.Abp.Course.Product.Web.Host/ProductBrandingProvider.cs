using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Zo.Abp.Course.Product
{
    [Dependency(ReplaceServices = true)]
    public class ProductBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Product";
    }
}
