using OpenQA.Selenium;
using SharebookQA.UI.Helpers;
using Xunit;

namespace SharebookQA.UI.PageObjects
{
    public class CommonPage
    {
        private IWebDriver _driver;

        public CommonPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement WelcomeUserID
        {
            get
            {
                return _driver.FindElement(By.Id("welcomeUser"));
            }
        }

        public void CheckText(string text)
        {
            var innerText = WelcomeUserID.GetInnerText();
            Assert.Equal(text, innerText);
        }
    }
}
