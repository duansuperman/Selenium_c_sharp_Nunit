using IWebDriver_Commands.Service;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWebDriver_Commands.TestSuites
{
    class less5_Read_Json_file
    {

        [Test]
        public void TestReadJson()
        {
            var jobj = JsonDriver.ReadDataFromJson("D:\\Khóa học selenimum C#\\Selenium c# - framework\\Operations\\IWebDriver\\IWebDriver_Commands\\TestData\\Text.json");

            //Get value of key child

            string t = jobj["Json"]["j2"].Value<String>();

            Console.WriteLine(t);

            //Get value of key parent

            string k = jobj["PowerOff"].Value<String>();

            Console.WriteLine(jobj["PowerOff"].Value<String>());

            //Get value from array in json

            Console.WriteLine(jobj["Array"][1]["a2"].Value<String>());

        }
    }
}
