using Abp.AspNetCore.Mvc.ViewComponents;

namespace QucikTrade.FinancialBusinessSystem.Web.Views
{
    public abstract class FinancialBusinessSystemViewComponent : AbpViewComponent
    {
        protected FinancialBusinessSystemViewComponent()
        {
            LocalizationSourceName = FinancialBusinessSystemConsts.LocalizationSourceName;
        }
    }
}
