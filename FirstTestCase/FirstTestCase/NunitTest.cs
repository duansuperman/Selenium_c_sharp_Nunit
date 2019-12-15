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
        public void OpenAppTest() //Passed
        {
            driver.Navigate().GoToUrl("http://www.demoqa.com");
        }
        [Test]
        public void OpenAppTest1() //Failed
        {
            driver.Navigate().GoToUrl("demoqa1.com"); 
        }
        [TearDown]  //Terminate the test
        public void EndTest()
        {
            driver.Close();
        }
    }
}
