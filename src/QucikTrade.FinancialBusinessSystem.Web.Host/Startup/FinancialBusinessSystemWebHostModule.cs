using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QucikTrade.FinancialBusinessSystem.Configuration;

namespace QucikTrade.FinancialBusinessSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(FinancialBusinessSystemWebCoreModule))]
    public class FinancialBusinessSystemWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FinancialBusinessSystemWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinancialBusinessSystemWebHostModule).GetAssembly());
        }
    }
}
