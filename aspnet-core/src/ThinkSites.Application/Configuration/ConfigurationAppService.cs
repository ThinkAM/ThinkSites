using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ThinkSites.Configuration.Dto;

namespace ThinkSites.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ThinkSitesAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
