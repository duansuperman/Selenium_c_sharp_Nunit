using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWebDriver_Commands.TestSuites
{
    class less1_IWebdriver_Browser_Commands
    {
        ChromeDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();

            //Launch the ToolsQA Website
            driver.Url = "http://www.demoqa.com";
            driver.Navigate();
        }
        [Test]
        public void TestCommands()
        {

            // Storing Title name in String variable
            String Title = driver.Title;

            // Storing Title length in Int variable
            int TitleLength = driver.Title.Length;

            // Printing Title name on Console
            Console.Out.WriteLine("Title of the page is : " + Title);
        
            // Printing Title length on console
            Console.WriteLine("Length of the Title is : " + TitleLength);

            // Storing URL in String variable
            String PageURL = driver.Url;

            // Storing URL length in Int variable
            int URLLength = PageURL.Length;

            // Printing URL on Console
            Console.WriteLine("URL of the page is : " + PageURL);

            // Printing URL length on console
            Console.WriteLine("Length of the URL is : " + URLLength);

            // Storing Page Source in String variable
            String PageSource = driver.PageSource;

            // Storing Page Source length in Int variable
            int PageSourceLength = driver.PageSource.Length;

            // Printing Page Source on console
           Console.WriteLine("Page Source of the page is : " + PageSource);

            // Printing Page SOurce length on console
            Console.WriteLine("Length of the Page Source is : " + PageSourceLength);

        }
        [Test]
        public void TestCommands1()
        {

        }
        [TearDown]
        public void EndTest()
        {
            driver.Quit();//Close all windows displaying
        }
    }
}
