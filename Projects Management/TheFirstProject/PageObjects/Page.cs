using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirstProject.PageObjects
{
    class Page 
    {
        [Obsolete]
        public static T getPage<T>(IWebDriver driver) where T : new()
        {
            var page = new T();
            PageFactory.InitElements(driver,page);
            return page ;
        }

        [Obsolete]
        public static LoginPage Login(IWebDriver driver)
        {
            return getPage<LoginPage>(driver);
        }
    }
}
