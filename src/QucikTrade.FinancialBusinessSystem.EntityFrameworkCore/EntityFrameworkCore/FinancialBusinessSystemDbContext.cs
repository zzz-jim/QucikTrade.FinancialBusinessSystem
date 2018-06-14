using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using QucikTrade.FinancialBusinessSystem.Authorization.Roles;
using QucikTrade.FinancialBusinessSystem.Authorization.Users;
using QucikTrade.FinancialBusinessSystem.MultiTenancy;

namespace QucikTrade.FinancialBusinessSystem.EntityFrameworkCore
{
    public class FinancialBusinessSystemDbContext : AbpZeroDbContext<Tenant, Role, User, FinancialBusinessSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FinancialBusinessSystemDbContext(DbContextOptions<FinancialBusinessSystemDbContext> options)
            : base(options)
        {
        }
    }
}
