using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Zo.Abp.Course.Product.Pages
{
    public class IndexModel : ProductPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}