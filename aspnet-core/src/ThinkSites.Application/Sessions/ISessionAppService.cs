using System.Threading.Tasks;
using Abp.Application.Services;
using ThinkSites.Sessions.Dto;

namespace ThinkSites.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
