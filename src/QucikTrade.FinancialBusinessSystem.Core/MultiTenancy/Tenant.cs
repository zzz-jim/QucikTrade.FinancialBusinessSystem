using Abp.MultiTenancy;
using QucikTrade.FinancialBusinessSystem.Authorization.Users;

namespace QucikTrade.FinancialBusinessSystem.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
