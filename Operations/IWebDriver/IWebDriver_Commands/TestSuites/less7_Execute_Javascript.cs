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

            //Get element of country dropdown

            var countryDropdown = driver.FindElementById("ctl00_ContentMain_DropdownListCountry");

            //Select option by executing javascript

            driver.ExecuteScript("var select = arguments[0]; for(var i=0;i<select.options.length;i++){if (select.options[i].text == arguments[1]){select.options[i].selected = true; }}",countryDropdown,"India");

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
