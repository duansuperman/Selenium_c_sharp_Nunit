using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirstProject.PageObjects
{
    class LoginPage
    {


       // Webelements in login page

        [FindsBy(How = How.XPath, Using = ".//input[@type=\"email\"]")]
        [CacheLookup]
        private IWebElement email { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@type=\"password\"]")]
        [CacheLookup]
        private IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@type=\"submit\"]")]
        [CacheLookup]
        private IWebElement login { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[@class='fancy-checkbox element-left']/span")]
        private IWebElement remember { get; set; }

        [FindsBy(How=How.XPath,Using = ".//span[@class='helper-text m-b-10']/a")]
        [CacheLookup]
        private IWebElement forgotPassword {get;set;}

        [Obsolete]
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public LoginPage()
        {
           
        }

        public LoginPage InputEmail(string mail)
        {
            email.SendKeys(mail);
            return this;
        }

        public LoginPage InputPassword(string pass)
        {
            password.SendKeys(pass);
            return this;
        }

        public LoginPage ClickRemember()
        {
            remember.Click();
            return this;
        }

        public LoginPage ClickLogin()
        {
            this.login.Click();
            return this;
        }
    }
}
