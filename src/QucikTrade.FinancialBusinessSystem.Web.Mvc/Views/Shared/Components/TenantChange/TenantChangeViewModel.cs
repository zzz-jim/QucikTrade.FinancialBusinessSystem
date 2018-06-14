using Abp.AutoMapper;
using QucikTrade.FinancialBusinessSystem.Sessions.Dto;

namespace QucikTrade.FinancialBusinessSystem.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
