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
    class less9_Handle_Dynamic_Webtables
    {

        ChromeDriver driver;

        [SetUp]

        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Url = "https://en.wikipedia.org/wiki/Programming_languages_used_in_most_popular_websites";
        }

        [Test]

        public void Test()
        {
            IWebElement elementTable = driver.FindElement(By.XPath(".//div[@id='mw-content-text']//table[1]"));

            //Get all rows from table

            IReadOnlyCollection<IWebElement> listTr = elementTable.FindElements(By.TagName("tr"));

            //Fetch each of rows

            foreach(var itemTr in listTr)
            {

                //Fetch all column of each row

                IReadOnlyCollection<IWebElement> listTd = itemTr.FindElements(By.TagName("td"));

                //Print a row

                foreach(var itemTd in listTd)
                {

                    Console.Write(itemTd.Text + "\t\t");

                }

                Console.WriteLine();
            }
        }

        [TearDown]

        public void EndTest()
        {

        }
    }
}
