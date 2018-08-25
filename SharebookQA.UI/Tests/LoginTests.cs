using SharebookQA.UI.PageObject;
using SharebookQA.UI.PageObjects;
using Xunit;

namespace SharebookQA.UI.Tests
{
    public class LoginTests : SeleniumBase
    {
        private readonly LoginPage loginPageObject;
        private readonly CommonPage commonPage;
        public LoginTests()
        {
            url = "http://localhost:4200/login";
            driver.Navigate().GoToUrl(url);
            loginPageObject = new LoginPage(driver);
            commonPage = new CommonPage(driver);


        }

        [Fact]
        public void LoginSucces()
        {
            loginPageObject.Login("walter.vlopes@gmail.com", "123456");
            commonPage.CheckText("Seja bem-vindo, Walter Vinicius Lopes Cardoso");
        } 
    }
}
