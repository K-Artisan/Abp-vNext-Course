using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Zo.Abp.Course.Product.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
    }
}
