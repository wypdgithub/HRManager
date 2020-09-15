using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace HRManage.Web.Views
{
    public abstract class HRManageRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected HRManageRazorPage()
        {
            LocalizationSourceName = HRManageConsts.LocalizationSourceName;
        }
    }
}
