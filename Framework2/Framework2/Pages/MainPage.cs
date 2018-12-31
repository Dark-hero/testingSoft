using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework2.Pages
{
    class MainPage
    {
        private const string BASE_URL = "https://www.skyscanner.ru/";
        
        [FindsBy(How = How.Name, Using = "origin-fsc-search")]
        public IWebElement FromCity { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#destination-fsc-search")]
        public IWebElement ToCity { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#return-fsc-datepicker-button > span")]
        public IWebElement ToDate { get; set; }

        [FindsBy(How = How.CssSelector,Using = "#flights-search-controls-root > div > div > form > div:nth-child(1) > div > label:nth-child(2)")]
        public IWebElement OneWayButton { get; set; }

        [FindsBy(How =How.CssSelector,Using = "#fsc-class-travellers-trigger-1PZXn > span")]
        public IWebElement ClassAndPassengers { get; set; }

        [FindsBy(How = How.Id, Using = "search-controls-cabin-class-dropdown")]
        public IWebElement ClassSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#search-controls-cabin-class-dropdown > option:nth-child(2)")]
        public IWebElement PremiumEconomyOption { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#search-controls-cabin-class-dropdown > option:nth-child(3)")]
        public IWebElement BusinessClassOption { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#search-controls-cabin-class-dropdown > option:nth-child(4)")]
        public IWebElement FirstClassOption { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cabin-class-travellers-popover > div > div > div:nth-child(4) > div > button:nth-child(3) > span > svg")]
        public IWebElement AddAdult { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cabin-class-travellers-popover > div > div > div:nth-child(6) > div > button:nth-child(3) > span > svg")]
        public IWebElement AddChild { get; set; }
       
        [FindsBy(How = How.CssSelector, Using = "#flights-search-controls-root > div > div > form > div:nth-child(3) > button")]
        public IWebElement FindButton { get; set; }

        private IWebDriver webDriver;

        public MainPage(IWebDriver driver)
        {
            webDriver = driver;

            PageFactory.InitElements(webDriver, this);
        }

        public void OpenPage()
        {
            webDriver.Navigate().GoToUrl(BASE_URL);
        }

    }
}
