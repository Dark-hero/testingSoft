using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium
{
    [TestFixture]
    class Selenium
    {

        private const string url = "https://www.skyscanner.ru/";

        [Test]
        static void Main(string[] args)
        {
            try
            { 
                IWebDriver chrome = new ChromeDriver();
                chrome.Url = url;
                chrome.FindElement(By.Name("origin-fsc-search")).SendKeys("Минск Интернэшнл 2 (MSQ)");
                chrome.FindElement(By.Name("destination-fsc-search")).SendKeys("Баку Гейдар Алиев (GYD)");
                chrome.FindElement(By.Name("depart-fsc-datepicker-input")).SendKeys("11.11.2018");
                chrome.FindElement(By.Name("return-fsc-datepicker-input")).SendKeys("31.12.2018");
                chrome.FindElement(By.Id("bpk-button")).Click();
                ReadOnlyCollection<IWebElement> h5elements = chrome.FindElements(By.TagName("h5"));
                foreach (var h5 in h5elements)
                {
                    Assert.AreNotEqual(h5.Text.ToLower(), "Return".ToLower());
                }
            }
            catch (NoSuchElementException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
