using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using QucikTrade.FinancialBusinessSystem.Configuration;
using QucikTrade.FinancialBusinessSystem.Web;

namespace QucikTrade.FinancialBusinessSystem.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FinancialBusinessSystemDbContextFactory : IDesignTimeDbContextFactory<FinancialBusinessSystemDbContext>
    {
        public FinancialBusinessSystemDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FinancialBusinessSystemDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            FinancialBusinessSystemDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FinancialBusinessSystemConsts.ConnectionStringName));

            return new FinancialBusinessSystemDbContext(builder.Options);
        }
    }
}
