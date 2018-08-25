using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SharebookQA.UI.Helpers;

namespace SharebookQA.UI.PageObject
{
    public class LoginPage
    {
        private IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement TxtEmail {
            get
            {
                return _driver.FindElement(By.Id("txtEmail"));
            }
        }

        private IWebElement TxtPassword
        {
            get
            {
                return _driver.FindElement(By.Id("txtPassword"));
            }
        }

        private IWebElement BtnLogin
        {
            get
            {
                return _driver.FindElement(By.Id("btnLogin"));
            }
        }

        public void Login(string email, string password)
        {
            TxtEmail.EnterText(email);
            TxtPassword.EnterText(password);
            BtnLogin.Click();   
        }
    }
}
