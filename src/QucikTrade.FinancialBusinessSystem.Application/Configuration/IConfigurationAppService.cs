using System.Threading.Tasks;
using QucikTrade.FinancialBusinessSystem.Configuration.Dto;

namespace QucikTrade.FinancialBusinessSystem.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
