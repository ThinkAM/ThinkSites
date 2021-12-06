using Abp.Application.Services;
using ThinkSites.MultiTenancy.Dto;

namespace ThinkSites.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

