using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestCase
{
    class NunitTest
    {
        ChromeDriver driver;
        [SetUp]  //Start beginning
        public void Initialize()
        {
            driver = new ChromeDriver();
        }
        [Test]  //Execute the test
        public void OpenAppTest()
        {
            driver.Navigate().GoToUrl("http://www.demoqa.com");
        }
        [TearDown]  //Terminate the test
        public void EndTest()
        {
            driver.Close();
        }
    }
}
