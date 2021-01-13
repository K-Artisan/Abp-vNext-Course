using System.Threading.Tasks;
using Zo.Store.Identity.Localization;
using Volo.Abp.UI.Navigation;

namespace Zo.Store.Identity.Blazor.Host
{
    public class IdentityHostMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<IdentityResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "Identity.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}
