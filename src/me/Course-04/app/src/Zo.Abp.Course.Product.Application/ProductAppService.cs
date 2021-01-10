using System;
using System.Collections.Generic;
using System.Text;
using Zo.Abp.Course.Product.Localization;
using Volo.Abp.Application.Services;

namespace Zo.Abp.Course.Product
{
    /* Inherit your application services from this class.
     */
    public abstract class ProductAppService : ApplicationService
    {
        protected ProductAppService()
        {
            LocalizationResource = typeof(ProductResource);
        }
    }
}
