using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThinkSites.EntityFrameworkCore;
using ThinkSites.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ThinkSites.Web.Tests
{
    [DependsOn(
        typeof(ThinkSitesWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ThinkSitesWebTestModule : AbpModule
    {
        public ThinkSitesWebTestModule(ThinkSitesEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ThinkSitesWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ThinkSitesWebMvcModule).Assembly);
        }
    }
}