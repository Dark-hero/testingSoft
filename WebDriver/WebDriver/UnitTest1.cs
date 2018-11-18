using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace WebDriver
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver chrome = new ChromeDriver(@"D:\UCH\4KURS\Tests\lab1\ConsoleApp1\testingSoft\WebDriver\WebDriver\bin\Debug");

        [TestMethod]
        public void TestMethod1()
        {

            chrome.Navigate().GoToUrl("https://www.skyscanner.ru/");

            chrome.FindElement(By.CssSelector(@"#origin-fsc-search")).SendKeys("Минск Интернэшнл 2 (MSQ)");

            chrome.FindElement(By.CssSelector(@"#destination-fsc-search")).SendKeys("Баку Гейдар Алиев (GYD)");

            chrome.FindElement(By.CssSelector(@"#flights-search-controls-root > div > div > form > div:nth-child(3) > button")).Click();

            bool actual = false;
            Thread.Sleep(500);
            try
            {

                chrome.FindElement(By.CssSelector(@"#day-section > div > div.day-main-content > div.day-list-container.clearfix.fss-tap-anywhere.tap-b.animate-plane > div > ul > li:nth-child(1) > div > article > div > div.bpk-ticket__paper.bpk-ticket__stub.Ticket__cta-container-2J185.bpk-ticket__stub--padded.bpk-ticket__stub--horizontal"));
            }
            catch (Exception)
            {
                actual = true;
            }

            Assert.AreEqual(true, actual);
        }
        [TestCleanup]
        public void TearDown()
        {
            chrome.Quit();
        }
    }
}
