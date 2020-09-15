using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HRManage.Controllers
{
    public abstract class HRManageControllerBase: AbpController
    {
        protected HRManageControllerBase()
        {
            LocalizationSourceName = HRManageConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
