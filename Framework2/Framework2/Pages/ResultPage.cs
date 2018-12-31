using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Framework2.Pages
{
    class ResultPage
    {
        [FindsBy(How = How.CssSelector, Using = "#simplified-search-controls-origin")]
        public IWebElement CityFrom { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#simplified-search-controls-destination")]
        public IWebElement CityTo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#filter-direct-stops-label")]
        public IWebElement DirectFlights { get; set; }

        
        [FindsBy(How = How.CssSelector, Using = "#day-section > div > div.day-main-content > div.day-list-container.clearfix.fss-tap-anywhere.tap-b.animate-plane > div > ul > li:nth-child(1) > div > article > div > div.bpk-ticket__paper.bpk-ticket__main.bpk-ticket__main--padded.bpk-ticket__main--horizontal")]
        public IWebElement SeeFlights { get; set; }

        private IWebDriver webDriver { get; set; }

        public ResultPage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(webDriver, this);
        }
    }
}
