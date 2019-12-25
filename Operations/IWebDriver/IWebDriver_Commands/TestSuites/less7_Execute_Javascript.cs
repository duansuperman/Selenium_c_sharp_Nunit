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
    class less7_Execute_Javascript
    {

        ChromeDriver driver;

        [SetUp]

        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.c-sharpcorner.com/register";

            //Scale full maximize screen
            driver.Manage().Window.Maximize();
        }

        [Test]

        public void Test()
        {
            
            //Get element email input

            IWebElement EnterEmail = driver.FindElement(By.Id("ctl00_ContentMain_TextBoxEmail"));


            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            //Set value for "Email" field

            jse.ExecuteScript("document.getElementById('ctl00_ContentMain_TextBoxEmail').value='khajamoizuddin@gmail.com'");

            //or

            jse.ExecuteScript("arguments[0].value = 'duansupper@gmail.com'",EnterEmail);

            //or

            string mail = "abcxyz@gmail.com";
            jse.ExecuteScript("arguments[0].value = arguments[1]", EnterEmail, mail);

            //Get element button register

            var registerButton = driver.FindElementById("csharLogin");

            //Click on the register button

            jse.ExecuteScript("arguments[0].click()", registerButton);


        }

        [TearDown]

        public void EndTest()
        {

        }
    }
}
