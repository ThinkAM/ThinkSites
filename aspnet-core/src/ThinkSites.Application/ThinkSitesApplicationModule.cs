using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThinkSites.Authorization;

namespace ThinkSites
{
    [DependsOn(
        typeof(ThinkSitesCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ThinkSitesApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ThinkSitesAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ThinkSitesApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
