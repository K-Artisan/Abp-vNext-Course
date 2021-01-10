﻿using Localization.Resources.AbpUi;
using Zo.Abp.Course.Product.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Zo.Abp.Course.Product
{
    [DependsOn(
        typeof(ProductApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class ProductHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(ProductHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<ProductResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
