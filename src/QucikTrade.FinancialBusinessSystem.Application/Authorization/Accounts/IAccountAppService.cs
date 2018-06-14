using System.Threading.Tasks;
using Abp.Application.Services;
using QucikTrade.FinancialBusinessSystem.Authorization.Accounts.Dto;

namespace QucikTrade.FinancialBusinessSystem.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
