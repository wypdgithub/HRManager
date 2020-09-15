using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HRManage.EntityFrameworkCore;
using HRManage.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace HRManage.Web.Tests
{
    [DependsOn(
        typeof(HRManageWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class HRManageWebTestModule : AbpModule
    {
        public HRManageWebTestModule(HRManageEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HRManageWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(HRManageWebMvcModule).Assembly);
        }
    }
}