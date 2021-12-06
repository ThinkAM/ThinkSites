using System.Threading.Tasks;
using ThinkSites.Configuration.Dto;

namespace ThinkSites.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
