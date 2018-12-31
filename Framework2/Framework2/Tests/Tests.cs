using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using Assert = NUnit.Framework.Assert;

namespace Framework2.Tests
{
    [TestFixture]
    class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void StartBrowser()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void FromCityWasNotSpecified()
        {
            steps.OpenMainPage();
            steps.ClearFromCity();
            steps.FindResults();
            steps.OpenResultPage();
            var fromCity = steps.GetResultFromCity();
            Assert.AreEqual(fromCity, "Минск Интернэшнл 2 (MSQ)");
        }

        [Test]
        public void ToCityWasNotSpecified()
        {
            steps.OpenMainPage();
            steps.ClearToCity();
            steps.FindResults();
            steps.OpenResultPage();
            var toCity = steps.GetResultToCity();
            Assert.AreEqual(toCity, "Везде");
        }

        [Test]
        public void SelectPremiumEconomyClass()
        {
            steps.OpenMainPage();
            steps.WriteToCity("Баку Гейдар Алиев (GYD)");
            steps.SelectPremiumEcomomyClass();
            var classAndPassenger = steps.GetClassAndPassengersValue();
          
            Assert.AreEqual(classAndPassenger  , "1 взрослый, Премиум-эконом");
        }

        [Test]
        public void SelectBusinessClass()
        {
            steps.OpenMainPage();
            steps.WriteToCity("Баку Гейдар Алиев (GYD)");
            steps.SelectBusinessClass();
            var classAndPassenger = steps.GetClassAndPassengersValue();

            Assert.AreEqual(classAndPassenger, "1 взрослый, Бизнес класс");
        }

        [Test]
        public void SelectFirstClass()
        {
            steps.OpenMainPage();
            steps.WriteToCity("Баку Гейдар Алиев (GYD)");
            steps.SelectFirstClass();
            var classAndPassenger = steps.GetClassAndPassengersValue();

            Assert.AreEqual(classAndPassenger, "1 взрослый, Первый класс");
        }

        [Test]
        public void AddAdult()
        {
            steps.OpenMainPage();
            //steps.WriteToCity("Баку Гейдар Алиев (GYD)");
            steps.IncreaseAdult();
            var classAndPassenger = steps.GetClassAndPassengersValue();

            Assert.AreEqual(classAndPassenger, "2 пассажиры, Эконом");
        }

        [Test]
        public void AddChild()
        {
            steps.OpenMainPage();
            //steps.WriteToCity("Баку Гейдар Алиев (GYD)");
            steps.IncreaseChild();
            var classAndPassenger = steps.GetClassAndPassengersValue();

            Assert.AreEqual(classAndPassenger, "2 пассажиры, Эконом");
        }


        [Test]
        public void ApplyBaggageIsEnabledTest()
        {
            steps.OpenMainPage();
            steps.ClickOneWay();
            var returnDate = steps.GetReturnDate();
            Assert.AreEqual(returnDate, "(В одну сторону)");
        }

        [Test]
        public void ApplyExchangeIsPossibleTest()
        {
            steps.OpenMainPage();
            steps.WriteToCity("Баку Гейдар Алиев (GYD)");
            steps.FindResults();
            steps.OpenResultPage();
            Assert.IsTrue(steps.GetSeeFlights().Displayed);
        }
              
        static void Main(string[] args) { }
    }
}
