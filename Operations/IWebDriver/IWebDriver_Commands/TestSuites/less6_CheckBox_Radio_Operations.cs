using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IWebDriver_Commands.TestSuites
{
    class less6_CheckBox_Radio_Operations
    {
        ChromeDriver driver;

        [SetUp]

        public void Intialize()
        {
            driver = new ChromeDriver();

            //Navigate to practice page

            driver.Navigate().GoToUrl("https://www.toolsqa.com/automation-practice-form/");
        }

        [Test]

        public void Test()
        {

            //challenge 1 - select the deselected radio button (female)

            driver.ExecuteScript("jQuery('#sex-1').click()");

            //Challenge 2 - select the third radio button for category "years of Experience"

            driver.ExecuteScript("jQuery('#exp-4').click()");

            //Challenge 3 - select the checkbox "Automation Tester" for category "Profession"

            driver.ExecuteScript("jQuery('#profession-1').click()");

            //Challenge 4 - select checkbox "Selenium IDE" for category "Automation tool"

            driver.ExecuteScript("jQuery('#tool-1').click()");

           
        }

        [TearDown]

        public void EndTest()
        {
            //driver.Quit(); //Close all windows opening 
        }
    }
}
