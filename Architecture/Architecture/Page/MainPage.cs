using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;

namespace Architecture.Page
{
    class MainPage
    {
        private const string url = "https://avia.tutu.ru/";
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#origin-fsc-search")]
        private IWebElement from;

        [FindsBy(How = How.CssSelector, Using = "#destination-fsc-search")]
        public IWebElement to;

        [FindsBy(How = How.CssSelector, Using = "#flights-search-controls-root > div > div > form > div:nth-child(3) > button")]
        public IWebElement buttonSearch;

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            Console.WriteLine("Initial page opened");
        }

        public void Search(string From, string To)
        {
            from.SendKeys(From);
            to.SendKeys(To);
            buttonSearch.Click();
        }
    }
}
