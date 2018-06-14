using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QucikTrade.FinancialBusinessSystem.Configuration;
using QucikTrade.FinancialBusinessSystem.EntityFrameworkCore;
using QucikTrade.FinancialBusinessSystem.Migrator.DependencyInjection;

namespace QucikTrade.FinancialBusinessSystem.Migrator
{
    [DependsOn(typeof(FinancialBusinessSystemEntityFrameworkModule))]
    public class FinancialBusinessSystemMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public FinancialBusinessSystemMigratorModule(FinancialBusinessSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(FinancialBusinessSystemMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                FinancialBusinessSystemConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinancialBusinessSystemMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
