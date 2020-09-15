using System.Threading.Tasks;
using HRManage.Models.TokenAuth;
using HRManage.Web.Controllers;
using Shouldly;
using Xunit;

namespace HRManage.Web.Tests.Controllers
{
    public class HomeController_Tests: HRManageWebTestBase
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