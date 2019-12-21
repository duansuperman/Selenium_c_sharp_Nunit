using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IWebDriver_Commands.TestSuites
{
    class less2_Navigation
    {
        ChromeDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com");

        }
        [Test]
        public void TestNavigation()
        {
            //Click on Sortable link
            driver.FindElementByXPath(".//div[@id=\"sidebar\"]//ul//li[1]//a").Click();

            //Stop for 2s to check result
            Thread.Sleep(2000);

            //Again go back to the home page
            driver.Navigate().Back();

            //Stop for 2s to check result
            Thread.Sleep(2000);

            //Again go forward to the page accessed previous
            driver.Navigate().Forward();

            //Stop for 2s to check result
            Thread.Sleep(2000);

            //Refreshes the current page
            driver.Navigate().Refresh();
        }
        [TearDown]
        public void EndTest()
        {
            driver.Quit(); //Close all window
        }
    }
}
