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
    class less11_Handle_Multi_Windows
    {

        ChromeDriver driver;

        string newBrowserWindow_Xpath = ".//button[@id=\"button1\"]";

        [SetUp]

        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.toolsqa.com/automation-practice-switch-windows/";
        }

        [Test]

        public void Test()
        {
            //Print the parent window

            string parentWindow = driver.CurrentWindowHandle;

            Console.WriteLine("Parent window's handle -> " + parentWindow);

            for(int i = 0; i < 3; i++)
            {

                IJavaScriptExecutor jse = (IJavaScriptExecutor) driver;

                //Get element object of new browser window button

                IWebElement newBrowserWindow_Element = driver.FindElementByXPath(newBrowserWindow_Xpath);

                jse.ExecuteScript("arguments[0].click()", newBrowserWindow_Element);

               
            }

            //Get all windows of both one parent and many childs

            List<String> stringWindow = driver.WindowHandles.ToList();

            foreach(string item in stringWindow)
            {

                //print each and very window in the list of string windows

                Console.WriteLine(item);

                //Switch to child window which is fetched from the focused window

                driver.SwitchTo().Window(item);

                //Navigates to the goodle chrome url

                driver.Navigate().GoToUrl("https://www.google.com/");

            }

           
            //Must assign to focus another window to continue using the next command

            driver.SwitchTo().Window(stringWindow.ElementAt(3));
            
            driver.Close();
        }

        [TearDown]

        public void End()
        {

        }
    }
}
