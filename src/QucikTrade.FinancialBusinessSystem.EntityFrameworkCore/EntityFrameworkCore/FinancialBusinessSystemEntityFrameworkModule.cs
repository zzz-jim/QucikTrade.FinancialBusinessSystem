using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using QucikTrade.FinancialBusinessSystem.EntityFrameworkCore.Seed;

namespace QucikTrade.FinancialBusinessSystem.EntityFrameworkCore
{
    [DependsOn(
        typeof(FinancialBusinessSystemCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class FinancialBusinessSystemEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<FinancialBusinessSystemDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        FinancialBusinessSystemDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        FinancialBusinessSystemDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinancialBusinessSystemEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
