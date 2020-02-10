using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWebDriver_Commands.TestSuites
{
    class less14_Fluent_Wait
    {

        ChromeDriver driver;

        string visible_Xpath = ".//button[@id='invisibility']";

        [SetUp]

        public void Initialize()
        {
            driver = new ChromeDriver();

            //Access to page by the following url 
            driver.Url = "https://www.toolsqa.com/automation-practice-switch-windows/";

        }

        [Test]

        public void Test_WebDriverWait() {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));

            Func<IWebDriver, IWebElement> waitForElement = new Func<IWebDriver, IWebElement>((IWebDriver web) =>
            {
                IWebElement visible = driver.FindElementByXPath(visible_Xpath);

                if (visible.GetAttribute("style").Equals("color: black; visibility: visible;"))
                {
                    return visible;
                }

                return null;
                        
            });

            IWebElement visible_Btn = wait.Until(waitForElement);

            if(visible_Btn != null)
            {
                Console.WriteLine("Visible element have displayed");
            }
            else
            {
                Console.WriteLine("Visible element isn't displaying");
            }
        }

        [Test]

        public void Test_DefaultWait()
        {

            IWebElement visible_Btn = driver.FindElementByXPath(visible_Xpath);

            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(visible_Btn);

            wait.Timeout = TimeSpan.FromMinutes(1);

            wait.PollingInterval = TimeSpan.FromMilliseconds(250);

            Func<IWebElement, bool> waitForElement = new Func<IWebElement, bool>((IWebElement ele) =>
            {
                

                if (visible_Btn.GetAttribute("style").Equals("color: black; visibility: visible;"))
                {
                    return true;
                }

                return false;
            });

            if (wait.Until(waitForElement))
            {
                Console.WriteLine("Visible element have displayed ");
            }
            else
            {
                Console.WriteLine("Visible element is not displaying");
            }

        }
    }
}
