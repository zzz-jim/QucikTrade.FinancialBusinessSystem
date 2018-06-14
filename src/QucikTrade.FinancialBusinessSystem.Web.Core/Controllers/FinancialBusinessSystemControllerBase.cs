using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace QucikTrade.FinancialBusinessSystem.Controllers
{
    public abstract class FinancialBusinessSystemControllerBase: AbpController
    {
        protected FinancialBusinessSystemControllerBase()
        {
            LocalizationSourceName = FinancialBusinessSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
