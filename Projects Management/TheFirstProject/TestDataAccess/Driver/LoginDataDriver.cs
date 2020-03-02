using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirstProject.TestDataAccess.Model;

namespace TheFirstProject.TestDataAccess.Driver
{
    class LoginDataDriver
    {
        public static string k = "abc";
        public static string getConnectionString()
        {
            string loginData_Path = ConfigurationManager.ConnectionStrings["LoginData_Path"].ConnectionString;
            string strCon = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", loginData_Path);
            return strCon;
        }

        public static OleDbConnection getConnection()
        {
            return new OleDbConnection(getConnectionString());
        }

        public static LoginData GetTestData(string keyName)
        {
            using (OleDbConnection connection = getConnection())
            {
     
                connection.Open();

                string query = string.Format("select * from [LoginData$] where key='{0}'", keyName);
                LoginData value = connection.Query<LoginData>(query).FirstOrDefault();

                connection.Close();
                return value;
            }
        }

        public static List<LoginData> GetAllTestDatas()
        {
            using(OleDbConnection conn = getConnection())
            {
                conn.Open();

                string query = "select * from [LoginData$]";
                List<LoginData> results = conn.Query<LoginData>(query).ToList();

                conn.Close();
                return results;
            }
        }

        public static void Print()
        {
            List<LoginData> list = GetAllTestDatas();
            for(int i = 0; i <= list.Count() - 1; i++)
            {
                Console.WriteLine(list[i].Email);
            }
        }
    }
}
