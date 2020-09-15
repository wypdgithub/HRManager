using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HRManage.Authorization;

namespace HRManage
{
    [DependsOn(
        typeof(HRManageCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HRManageApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HRManageAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HRManageApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
