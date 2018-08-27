using OpenQA.Selenium;

namespace SharebookQA.UI.Helpers
{
    public static class SeleniumGetMethods
    {
        public static string GetInnerText(this IWebElement element)
           => element.GetAttribute("innerText");
    }
}
