using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThinkSites.Configuration;

namespace ThinkSites.Web.Host.Startup
{
    [DependsOn(
       typeof(ThinkSitesWebCoreModule))]
    public class ThinkSitesWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ThinkSitesWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ThinkSitesWebHostModule).GetAssembly());
        }
    }
}
