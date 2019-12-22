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
    class less4_FindElement_FindElemements
    {

        ChromeDriver driver;

        [SetUp]
        public void Initialize()
        {
            //Open web of tiki ecommere

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://tiki.vn/");

        }
        [Test]
        public void FindElement()
        {

            //all action of FindElement return a object

            //Id

            driver.FindElement(By.Id("Id name"));

            //Name

            driver.FindElement(By.Name("Name"));

            //ClassName

            driver.FindElement(By.ClassName("Class name"));

            //TagName

            driver.FindElement(By.TagName("Tag name"));

            //Partial & PartialLinkText

            driver.FindElement(By.LinkText("Link text string"));

            driver.FindElement(By.PartialLinkText("Partial link text"));

        }
        [Test]
        public void FindElements()
        {

        }
        [TearDown]
        public void EndTest()
        {
            driver.Quit(); //Close all windows
        }
    }
}
