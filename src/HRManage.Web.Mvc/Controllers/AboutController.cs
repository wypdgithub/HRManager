using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using HRManage.Controllers;

namespace HRManage.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : HRManageControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
