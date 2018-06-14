using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace QucikTrade.FinancialBusinessSystem.Web.Views
{
    public abstract class FinancialBusinessSystemRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected FinancialBusinessSystemRazorPage()
        {
            LocalizationSourceName = FinancialBusinessSystemConsts.LocalizationSourceName;
        }
    }
}
