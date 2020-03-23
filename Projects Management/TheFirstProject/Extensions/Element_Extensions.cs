﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirstProject.Extensions
{
    static class Element_Extensions
    {
        public static void EnterText(this IWebElement element, string text, string elementName)
        {
            element.Clear();
            element.SendKeys(text);
            Console.WriteLine(text + " entered in the " + elementName + " field");
        }

        public static bool IsDisplayed(this IWebElement element, string elementName)
        {
            bool result;
            try
            {
                result = element.Displayed;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static void SelectByText(this IWebElement element, string text, string elementName)
        {
            SelectElement oSelect = new SelectElement(element);
            oSelect.SelectByText(text);
            Console.WriteLine(text + " text selected on " + elementName);
        }

        public static void SelectByIndex(this IWebElement element, int index, string elementName)
        {
            SelectElement oSelect = new SelectElement(element);
            oSelect.SelectByIndex(index);
            Console.WriteLine(index + " text selected on " + elementName);
        }

        public static void ClickOnIt(this IWebElement element, string elementName)
        {
            element.Click();
            Console.WriteLine("click on " + elementName);
        }
    }
}
