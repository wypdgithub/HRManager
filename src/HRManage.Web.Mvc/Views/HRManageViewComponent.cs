using Abp.AspNetCore.Mvc.ViewComponents;

namespace HRManage.Web.Views
{
    public abstract class HRManageViewComponent : AbpViewComponent
    {
        protected HRManageViewComponent()
        {
            LocalizationSourceName = HRManageConsts.LocalizationSourceName;
        }
    }
}
