using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using QucikTrade.FinancialBusinessSystem.Authorization.Roles;
using QucikTrade.FinancialBusinessSystem.Authorization.Users;
using QucikTrade.FinancialBusinessSystem.MultiTenancy;

namespace QucikTrade.FinancialBusinessSystem.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options, 
            SignInManager signInManager,
            ISystemClock systemClock) 
            : base(
                  options, 
                  signInManager, 
                  systemClock)
        {
        }
    }
}
