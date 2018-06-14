using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Configuration;
using QucikTrade.FinancialBusinessSystem.Configuration;
using QucikTrade.FinancialBusinessSystem.Configuration.Ui;

namespace QucikTrade.FinancialBusinessSystem.Web.Views.Shared.Components.RightSideBar
{
    public class RightSideBarViewComponent : FinancialBusinessSystemViewComponent
    {
        private readonly ISettingManager _settingManager;

        public RightSideBarViewComponent(ISettingManager settingManager)
        {
            _settingManager = settingManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var themeName = await _settingManager.GetSettingValueAsync(AppSettingNames.UiTheme);

            var viewModel = new RightSideBarViewModel
            {
                CurrentTheme = UiThemes.All.FirstOrDefault(t => t.CssClass == themeName)
            };

            return View(viewModel);
        }
    }
}
