using System.Threading.Tasks;
using ThinkSites.Models.TokenAuth;
using ThinkSites.Web.Controllers;
using Shouldly;
using Xunit;

namespace ThinkSites.Web.Tests.Controllers
{
    public class HomeController_Tests: ThinkSitesWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}