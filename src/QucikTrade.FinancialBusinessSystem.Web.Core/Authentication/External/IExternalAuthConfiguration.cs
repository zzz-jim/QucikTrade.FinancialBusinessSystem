using System.Collections.Generic;

namespace QucikTrade.FinancialBusinessSystem.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
