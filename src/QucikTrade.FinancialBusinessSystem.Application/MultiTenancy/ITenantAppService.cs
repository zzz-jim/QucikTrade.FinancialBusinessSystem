using Abp.Application.Services;
using Abp.Application.Services.Dto;
using QucikTrade.FinancialBusinessSystem.MultiTenancy.Dto;

namespace QucikTrade.FinancialBusinessSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
