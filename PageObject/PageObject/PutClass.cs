using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace PageObject
{
    [TestClass]
    class PutClass
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            Driver = new ChromeDriver(@"D:\UCH\4KURS\Tests\lab1\ConsoleApp1\testingSoft\WebDriver\WebDriver\bin\Debug");
            Wait = new WebDriverWait(Driver,TimeSpan.FromSeconds(30));
        }

        [TestCleanup]
        public void TearDownTest()
        {
            Driver.Quit();
        }

        [TestMethod]
        public void SearchTicket()
        {
            SkyScannerSearch ticket = new SkyScannerSearch(Driver);
            ticket.CheckResults(ticket.SearchElementClick());
        }
    }
}
