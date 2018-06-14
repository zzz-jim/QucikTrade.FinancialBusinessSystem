using System.Threading.Tasks;
using Abp.Application.Services;
using QucikTrade.FinancialBusinessSystem.Sessions.Dto;

namespace QucikTrade.FinancialBusinessSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
