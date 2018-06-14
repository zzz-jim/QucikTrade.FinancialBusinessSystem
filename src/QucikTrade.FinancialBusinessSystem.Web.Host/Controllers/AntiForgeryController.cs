using Microsoft.AspNetCore.Antiforgery;
using QucikTrade.FinancialBusinessSystem.Controllers;

namespace QucikTrade.FinancialBusinessSystem.Web.Host.Controllers
{
    public class AntiForgeryController : FinancialBusinessSystemControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
