using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ThinkSites.Controllers
{
    public abstract class ThinkSitesControllerBase: AbpController
    {
        protected ThinkSitesControllerBase()
        {
            LocalizationSourceName = ThinkSitesConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
