using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace QucikTrade.FinancialBusinessSystem.EntityFrameworkCore
{
    public static class FinancialBusinessSystemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FinancialBusinessSystemDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FinancialBusinessSystemDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
