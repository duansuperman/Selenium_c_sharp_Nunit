using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TheFirstProject.PageObjects;
using TheFirstProject.TestDataAccess.Driver;
using TheFirstProject.WrapperFactory;

namespace TheFirstProject
{
    public class TheFirstCase
    {

        IWebDriver driver;

        [SetUp]

        public void Initialize()
        {
            driver = (ChromeDriver) BrowserFactory.InitialBrowser("chrome");
            driver.Url = ConfigurationManager.AppSettings["Login_Url"];
        }

        [Test]
        [Obsolete]
        public void TestLogin()
        {
            //Initialize LoginPage object 
            LoginPage loginPage = Page.Login(driver);

            var loginTest = LoginDataDriver.GetTestData("LoginTest");

            loginPage.InputEmail(loginTest.Email)
            .InputPassword(loginTest.Password)
            .ClickRemember()
            .ClickLogin();
            Thread.Sleep(3000);

            //Validate Login function haved verified sucessfully
            Assert.IsTrue(driver.Url.Contains("user-admin"));
            
        }

        [TearDown]
        public void End()
        {
           driver.Quit();
        }
    }
}
