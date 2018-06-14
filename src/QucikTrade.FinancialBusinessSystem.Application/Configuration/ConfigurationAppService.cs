using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using QucikTrade.FinancialBusinessSystem.Configuration.Dto;

namespace QucikTrade.FinancialBusinessSystem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FinancialBusinessSystemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
