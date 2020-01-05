using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IWebDriver_Commands.TestSuites
{
    class less10_Handle_Alert_Popup_Box
    {
        ChromeDriver driver;

        string simpleAlert_Xpath = "//div[@class='wf-container-main']//p[3]/button";
        string confirmPopup_Xpath = "//div[@id='content']/p[7]/button";
        string promptPopup_Xpath = "//div[@id='content']/p[10]/button";

        [SetUp]

        public void InitialLize()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.toolsqa.com/handling-alerts-using-selenium-webdriver";

            //Set maximize for main window

            driver.Manage().Window.Maximize();
        }

        [Test]

        public void TestSimpleAlert()
        {

            //The first is producing an alert on screen

            IWebElement simpleAlert_Btn =  driver.FindElementByXPath(simpleAlert_Xpath);

            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            jse.ExecuteScript("arguments[0].click()", simpleAlert_Btn);

            //Switch the control of Driver to the alert from the main window

            IAlert simple_Alert = driver.SwitchTo().Alert();

            //Get text from the alert

            string text = simple_Alert.Text;
            Console.WriteLine("The content of the simple alert is : "+text);

            //Accept is used to accept the alert ( Click on OK button )

            simple_Alert.Accept();

        }

        [Test]

        public void TestConfirmPopup()
        {
            //Get object of Confirm Popup element

            IWebElement confirmPopup_Btn = driver.FindElementByXPath(confirmPopup_Xpath);

            //Creating an object of IJavascriptExecutor

            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            //Cath the clicking on the Confirm Popup button

            jse.ExecuteScript("arguments[0].click()", confirmPopup_Btn);

            //Switch the control of 'Driver' to the alert from the main window

            IAlert confirmPopup_Alert = driver.SwitchTo().Alert();

            //Method 'Text' is used to get text from alert

            string text = confirmPopup_Alert.Text;
            Console.WriteLine("The content of the confirm popup is : " + text);

            //Method 'Dismiss' is used to dismiss the alert currently

            confirmPopup_Alert.Dismiss();

        }

        [Test]

        public void TestPromptPopup()
        {
            //Get object of the Prompt Popup button

            IWebElement promptPopup_Btn = driver.FindElementByXPath(promptPopup_Xpath);

            //Creating the object of the IJavascriptExecutor

            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            jse.ExecuteScript("arguments[0].click()", promptPopup_Btn);

            //Switch the control of 'Driver' to the alert from the main window

            IAlert promptPopup_Alert = driver.SwitchTo().Alert();

            //The method 'Text' is used to get Text from alert currently

            string text = promptPopup_Alert.Text;

            //Send a part text to the prompt of alert

            promptPopup_Alert.SendKeys("I love automation than any things");

            //Sleep about 3s to look at, but it's not necessary

            Thread.Sleep(3000);

            //the method 'Accept()' is used to accept the alert

            promptPopup_Alert.Accept();

        }

        [TearDown]

        public void EndTest()
        {
            driver.Quit(); //Close all windows
        }
    }
}
