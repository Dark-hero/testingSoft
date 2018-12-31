using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework2.Driver;
using Framework2.Pages;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Framework2.Steps
{
    class Steps
    {
        public IWebDriver webDriver;

        private MainPage mainPage;

        private ResultPage resultPage;

        public void InitBrowser()
        {
            webDriver = Driver.Driver.GetInstance();
        }

        public void CloseBrowser()
        {
            webDriver = null;
            Driver.Driver.CloseBrowser();
        }

        public void OpenMainPage()
        {
            mainPage = new MainPage(webDriver);

            mainPage.OpenPage();
        }

        public void WriteFromCity(string city)
        {
             mainPage.FromCity.SendKeys(city);
        }

        public void WriteToCity(string city)
        {
             mainPage.ToCity.SendKeys(city);
        }

        public string GetResultFromCity()
        {
            var fromCity = resultPage.CityFrom;
            return Convert.ToString(fromCity.GetAttribute("value"));
        }

        public string GetResultToCity()
        {
            var toCity = resultPage.CityTo;
            return Convert.ToString(toCity.GetAttribute("value"));
        }
                
        public string GetClassAndPassengersValue()
        {
           return mainPage.ClassAndPassengers.Text;
        }

        public void ClearFromCity()
        {
            mainPage.FromCity.Clear();
        }

        public void ClearToCity()
        {
            mainPage.ToCity.Clear();
        }

        public void ClickOneWay()
        {
            mainPage.OneWayButton.Click();
        }
        private void ClickClassAndPassengers()
        {
            mainPage.ClassAndPassengers.Click();
        }

        private void ClickClass()
        {
            ClickClassAndPassengers();
            mainPage.ClassSearch.Click();
        }

        public void SelectPremiumEcomomyClass()
        {
            ClickClass();
            mainPage.PremiumEconomyOption.Click();
        }

        public void SelectBusinessClass()
        {
            ClickClass();
            mainPage.BusinessClassOption.Click();
        }

        public void SelectFirstClass()
        {
            ClickClass();
            mainPage.FirstClassOption.Click();
        }

        public void IncreaseAdult()
        {
            ClickClassAndPassengers();
            mainPage.AddAdult.Click();
        }

        public void IncreaseChild()
        {
            ClickClassAndPassengers();
            mainPage.AddChild.Click();
        }

       
        public IWebElement GetSeeFlights()
        {
            return resultPage.SeeFlights;
        }

        public string GetReturnDate()
        {
            return mainPage.ToDate.Text;
        }

        public void FindResults()
        {
            mainPage.FindButton.Click();
        }

        public void OpenResultPage()
        {
            resultPage = new ResultPage(webDriver);
        }

        
        public void DirectFlights()
        {
            resultPage.DirectFlights.Click();
        }
    }
}
