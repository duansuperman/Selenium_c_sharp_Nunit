using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IWebDriver_Commands.TestSuites
{
    class less8_Dropdown_MultipleSelecting
    {
        ChromeDriver driver;

        [SetUp]

        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Url = "http://toolsqa.com/automation-practice-form/";
        }

        [Test]

        public void Test()
        {
            //Get element object of dropdown

            IWebElement element = driver.FindElementById("Id of Dropdown");

            //Create a select element object which get all options

            SelectElement select = new SelectElement(element);

            //Select option by index - int

            select.SelectByIndex(1);

            //Select option by value

            select.SelectByValue("Input value of current option");

            //Select option by text

            select.SelectByText("Input text of option");

            //Foreach options in select tag

            IList<IWebElement> listElement = select.Options;

            for(int i = 0; i < listElement.Count; i++)
            {
                Console.WriteLine(listElement.ElementAt(i).Text);
            }

            //Multi select method 

            /*
            SelectElement oSelect = new SelectElement(driver.FindElement(By.Id(Element_ID)));
            oSelect.SelectByIndex(index);
            oSelect.SelectByIndex(index);

            // Or can be used as
            oSelect.SelectByText(text);
            oSelect.SelectByText(text);

            // Or can be used as
            oSelect.SelectByValue(value);
            oSelect.SelectByValue(value);

            */

        }

        [Test]

        public void Exercise1()
        {

            //Get all option of continents dropdown

            SelectElement selectOptions = new SelectElement(driver.FindElementById("continents"));

            //Select option with value is "Europe" by index

            selectOptions.SelectByIndex(1);

            //Select option with value Africa

            selectOptions.SelectByValue("AF");

            //Print all options in selected dropdown

            for(int i = 0; i < selectOptions.Options.Count; i++)
            {
                Console.WriteLine("Value of option at index " + i + " : " + selectOptions.Options.ElementAt(i).Text);
            }
            
        } 

        [Test]

        public void Exercise2()
        {

            //Get all option of Selenium commands multiple

            SelectElement selectOption = new SelectElement(driver.FindElement(By.Name("selenium_commands")));

            //Select option "Browser Commands" by index

            selectOption.SelectByIndex(0);

            Thread.Sleep(2000);

            //Deselect option "Browser Commands"

            selectOption.DeselectByIndex(0);

            //Select option "Navigation Commands"

            selectOption.SelectByIndex(1);

            Thread.Sleep(2000);

            //Deselect for option "Navigation Commands"

            selectOption.DeselectByIndex(1);

            //Print all options of selected multiple selection list

            for(int i = 0; i < selectOption.Options.Count; i++)
            {
                Console.WriteLine("The value of option at index " + i + " : " + selectOption.Options.ElementAt(i).Text);
            }


            //Deselect all options

            selectOption.DeselectAll();
        }

        [TearDown]

        public void EndTest()
        {
            //driver.Quit();
        }
    }
}
