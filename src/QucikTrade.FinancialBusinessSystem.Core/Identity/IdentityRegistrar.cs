using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using QucikTrade.FinancialBusinessSystem.Authorization;
using QucikTrade.FinancialBusinessSystem.Authorization.Roles;
using QucikTrade.FinancialBusinessSystem.Authorization.Users;
using QucikTrade.FinancialBusinessSystem.Editions;
using QucikTrade.FinancialBusinessSystem.MultiTenancy;

namespace QucikTrade.FinancialBusinessSystem.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
