using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using QucikTrade.FinancialBusinessSystem.Authorization.Roles;
using QucikTrade.FinancialBusinessSystem.Authorization.Users;
using QucikTrade.FinancialBusinessSystem.Configuration;
using QucikTrade.FinancialBusinessSystem.Localization;
using QucikTrade.FinancialBusinessSystem.MultiTenancy;
using QucikTrade.FinancialBusinessSystem.Timing;

namespace QucikTrade.FinancialBusinessSystem
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class FinancialBusinessSystemCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            FinancialBusinessSystemLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = FinancialBusinessSystemConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinancialBusinessSystemCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
