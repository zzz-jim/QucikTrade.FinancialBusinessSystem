using Abp.AutoMapper;
using QucikTrade.FinancialBusinessSystem.Authentication.External;

namespace QucikTrade.FinancialBusinessSystem.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
