using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SharebookQA.UI.Helpers
{
    public static class SeleniumSetMethods
    {
        public static void EnterText(this IWebElement element, string value) 
            => element.SendKeys(value);

        public static void Click(this IWebElement element) 
            => element.Click();

        public static void SelecDropDown(this IWebElement element, string value) 
            => new SelectElement(element).SelectByText(value);
    }
}
