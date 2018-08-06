using System;
using Spec2.Data;
using System.Configuration;
using Ganss.Excel;

namespace Spec2.Framework
{
    static class Prop
    {
        
        public static UserData GetUserType(String userType)
        {
            var userExcel = new ExcelMapper(@"C: \Users\rache\source\repos\Spec2\Spec2\Data.xls").Fetch<UserData>("UserData");
            var userExcelData = userExcel.GetEnumerator();
            while (userExcelData.MoveNext())
            {
                if (userExcelData.Current.UserType.Equals(ConfigurationManager.AppSettings["environment"] + userType))
                {
                    UserData current = userExcelData.Current;
                    Console.Write("Data " + ConfigurationManager.AppSettings["environment"] + userType);
                    return current;
                }

            }
            Console.Write("Error Data not found" + userType + " #######");

            return null;
        }

        internal static UserData GetUserType(object userType)
        {
            throw new NotImplementedException();
        }

        public static SettingsData Settings(String property)
        {
            var userExcel = new ExcelMapper(@"C:\Users\rache\source\repos\Spec2\Spec2\Data.xls").Fetch<SettingsData>("Settings");
            var userExcelData = userExcel.GetEnumerator();
            while (userExcelData.MoveNext())
            {
                if (userExcelData.Current.Property.Equals(ConfigurationManager.AppSettings["environment"] + property))
                {
                    SettingsData current = userExcelData.Current;
                    return current;

                }

            }
            Console.Write("Error Data not found for " + property + " #######");

            return null;
        }


    }
}
