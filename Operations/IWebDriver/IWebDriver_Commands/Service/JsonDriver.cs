using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWebDriver_Commands.Service
{
    class JsonDriver
    {
        public static JObject ReadDataFromJson(string pathToJson)
        {
            string filepath = pathToJson;
            
            using (StreamReader r = new StreamReader(filepath))
            {

                //Read file json

                var json = r.ReadToEnd();

                //convert json to jobject

                var jobj = JObject.Parse(json);

                return jobj;

            }
            
        }
        
    }
}
