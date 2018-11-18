using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Architecture.Tests
{
    [TestFixture]
    class Tests
    {
        private Steps.Steps steps = new Steps.Steps();
        private string From = "Минск Интернэшнл 2 (MSQ)";
        private string To = "Баку Гейдар Алиев (GYD)";

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void Search()
        {
            steps.SearchTickets(From,To);
        }
    }
}
