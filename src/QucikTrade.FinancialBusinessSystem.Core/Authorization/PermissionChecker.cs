using Abp.Authorization;
using QucikTrade.FinancialBusinessSystem.Authorization.Roles;
using QucikTrade.FinancialBusinessSystem.Authorization.Users;

namespace QucikTrade.FinancialBusinessSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
