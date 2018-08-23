using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Xunit;

namespace SharebookQA.UI
{
    public class SeleniumBase : IDisposable
    {
        public IWebDriver driver;

        public SeleniumBase()
        {
            try
            {
                driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao rodar o chrome..." + ex.Message);
               
            }
        }
        
        [Fact]
        public void AccessSharebookHomePage()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://stg.sharebook.com.br");
            Assert.Equal("ShareBook Organization", driver.Title);

        }

        public void Dispose()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao finalizar o chrome..." + ex.Message);
            }
        }
    }
}
