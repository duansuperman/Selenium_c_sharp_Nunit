using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirstProject.WrapperFactory
{
    static class BrowserFactory
    {
        public static IWebDriver driver { get; set; }

        //Initial a browser
        public static IWebDriver InitialBrowser(string nameBrowser)
        {
            if (nameBrowser == "chrome")
            {
                return new ChromeDriver();
            }
            else if(nameBrowser =="firefox")
            {
                return new FirefoxDriver();
            }
            else
            {
                return null;
            }
        }

        //
    }
}
