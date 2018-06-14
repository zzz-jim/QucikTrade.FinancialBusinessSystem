using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using QucikTrade.FinancialBusinessSystem.Controllers;

namespace QucikTrade.FinancialBusinessSystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FinancialBusinessSystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
