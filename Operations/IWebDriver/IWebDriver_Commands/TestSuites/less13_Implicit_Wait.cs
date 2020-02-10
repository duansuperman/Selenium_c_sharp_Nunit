using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWebDriver_Commands.TestSuites
{
    class less13_Implicit_Wait
    {

        ChromeDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.toolsqa.com/automation-practice-switch-windows/";
        }

        [Test]
        public void Test()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

            IWebElement visible_Element = driver.FindElementByXPath(".//button[@id='invisibility']");

            bool check = visible_Element.Displayed;

            Console.WriteLine(visible_Element.Text);

            if (check == true)
            {
                Console.WriteLine("Just visible");
            }
        }

        [TearDown]
        public void End()
        {

        }
    }
}
