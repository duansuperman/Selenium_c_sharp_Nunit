using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWebDriver_Commands.TestSuites
{
    class less3_WebElement_Commands
    {

        ChromeDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void ClearCommand() //Clear command
        {

            IWebElement element = driver.FindElement(By.Id("UserName"));
            element.Clear();

            //Or can be written as

            driver.FindElement(By.Id("UserName")).Clear();
        }

        [Test]
        public void SendKeys() // Send keys command
        {
            IWebElement element = driver.FindElement(By.Id("UserName"));
            element.SendKeys("ToolsQA");

            //Or can be written as

            driver.FindElement(By.Id("UserName")).SendKeys("ToolsQA");
        }

        [Test]
        public void Click() //Action click on element (links, text, radio,...)
        {
            IWebElement element = driver.FindElement(By.LinkText("ToolsQA"));
            element.Click();

            //Or can be written as

            driver.FindElement(By.LinkText("ToolsQA")).Click();
        }

        [Test]
        public void Displayed() //Displayed method
        {
            IWebElement element = driver.FindElement(By.Id("UserName"));
            bool status = element.Displayed;

            //Or can be written as

            bool staus = driver.FindElement(By.Id("UserName")).Displayed;
        }

        [Test]
        public void Enabled() //Check element is anabled or not ?
        {
            IWebElement element = driver.FindElement(By.Id("UserName"));
            bool status = element.Enabled;

            //Or can be written as

            bool staus = driver.FindElement(By.Id("UserName")).Enabled;

            //Or can be used as
            IWebElement element1 = driver.FindElement(By.Id("UserName"));
            bool status1 = element.Enabled;

            // Check that if the Text field is enabled, if yes enter value
            if (status)
            {
                element.SendKeys("ToolsQA");
            }
        }

        [Test]
        public void Selected() //Check elements choosed (Checkbox, radio, select options,...)
        {
            IWebElement element = driver.FindElement(By.Id("Sex-Male"));
            bool status = element.Selected;

            //Or can be written as

            bool staus = driver.FindElement(By.Id("Sex-Male")).Selected;
        }

        [Test]
        public void Submit() //Submit with form
        {
            IWebElement element = driver.FindElement(By.Id("SubmitButton"));
            element.Submit();

            //Or can be written as

            driver.FindElement(By.Id("SubmitButton")).Submit();
        }

        [Test]
        public void TextCommand() //Get text from elements This returns an innerText of the element, including sub-elements, without any leading or trailing whitespace.
        {
            IWebElement element = driver.FindElement(By.Id("SubmitButton"));
            element.Submit();

            //Or can be written as

            driver.FindElement(By.Id("SubmitButton")).Submit();
        }

        [Test]
        public void TagName()
        {
            IWebElement element = driver.FindElement(By.Id("SubmitButton"));
            String tagName = element.TagName;

            //Or can be written as

            String tagName1 = driver.FindElement(By.Id("SubmitButton")).TagName;
        }

        [Test]
        public void GetCssValue()
        {
            IWebElement element = driver.FindElement(By.Id("SubmitButton"));
            String cssValue = element.GetCssValue("backgroud-color");
        }

        [Test]
        public void GetAttribute() 
        {
            IWebElement element = driver.FindElement(By.Id("SubmitButton"));
            String attValue = element.GetAttribute("id"); //This will return "SubmitButton"
        }

        [Test]
        public void Size() //Get size (width, height)
        {
            IWebElement element = driver.FindElement(By.Id("SubmitButton"));
            var dimensions = element.Size;
            Console.WriteLine("Height:" +dimensions.Height + "Width: "+ dimensions.Width);
        }

        [Test]
        public void location()
        {
            IWebElement element = driver.FindElement(By.Id("SubmitButton"));
            Point point = element.Location;
            Console.WriteLine("X cordinate : " + point.X + "Y cordinate: " + point.Y);
        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
