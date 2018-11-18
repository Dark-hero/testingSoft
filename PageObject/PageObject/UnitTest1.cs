using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObject
{
    [TestClass]
    public class SkyScannerSearch
    {
        private readonly IWebDriver driver;
        private readonly string url = @"https://www.skyscanner.ru/";

        public SkyScannerSearch(IWebDriver webDriver)
        {
            driver = webDriver;
            driver.Manage().Window.Maximize();
            PageFactory.InitElements(webDriver, this);
        }

        [TestMethod]
        public bool SearchElementClick()
        {
            bool actual = false;
            try
            {
                driver.Navigate().GoToUrl(url);
                driver.FindElement(By.CssSelector(@"#origin-fsc-search")).SendKeys("Минск Интернэшнл 2 (MSQ)");
                driver.FindElement(By.CssSelector(@"#destination-fsc-search")).SendKeys("Баку Гейдар Алиев (GYD)");
                driver.FindElement(By.CssSelector(@"#flights-search-controls-root > div > div > form > div:nth-child(3) > button")).Click();
            }
            catch(Exception)
            {
                actual = true;
            }
            return actual;
        }

        public void CheckResults(bool actual)
        {
            Assert.IsTrue(actual);
        }


    }
}
