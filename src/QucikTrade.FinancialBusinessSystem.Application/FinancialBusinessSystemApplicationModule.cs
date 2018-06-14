using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QucikTrade.FinancialBusinessSystem.Authorization;

namespace QucikTrade.FinancialBusinessSystem
{
    [DependsOn(
        typeof(FinancialBusinessSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FinancialBusinessSystemApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FinancialBusinessSystemAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FinancialBusinessSystemApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
