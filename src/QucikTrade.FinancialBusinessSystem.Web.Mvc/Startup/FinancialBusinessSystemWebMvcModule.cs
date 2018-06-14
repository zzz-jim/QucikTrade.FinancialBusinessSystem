using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QucikTrade.FinancialBusinessSystem.Configuration;

namespace QucikTrade.FinancialBusinessSystem.Web.Startup
{
    [DependsOn(typeof(FinancialBusinessSystemWebCoreModule))]
    public class FinancialBusinessSystemWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FinancialBusinessSystemWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<FinancialBusinessSystemNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinancialBusinessSystemWebMvcModule).GetAssembly());
        }
    }
}
