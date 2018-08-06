using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spec2.Pages
{
    public class HolidayCollectionsPage : BasePage
    {
        private String pageTitle = "Luxury Tailor Made Holidays with Pettitts Travel";
        public HolidayCollectionsPage()
        {

        }

        public String HolidayCollectionsPageTitle()
        {
            Wait();
            Console.WriteLine("Title");
            Console.WriteLine(driver.Title);
            return driver.Title;
        }
        public String HolidayCollectionsPageExpectedTitle()
        {
            return pageTitle;
        }

        public void ClickHolidayCollection()
        {
            IWebElement HolidayCollections = driver.FindElement(By.XPath(@"//*[@id='content']/div[2]/div[3]/div[1]/div/div/button[2]/em"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", HolidayCollections);
            HolidayCollections.Click();
            Wait();
        }

        public bool IsChooseAHolidayCollection()
        {
            if (IsElementPresent(By.XPath(@"//*[@id='content']/div[2]/div[3]/div[1]/div/div/button[2]")))
            {
                return true;
            }
            else
            {
                return false;
            }




        }

        public void OptionsOfHolidayCollections()
        {
            IList<IWebElement> HoiC = driver.FindElements(By.XPath(@"//*[@id='homepage-dropdown-menu']/li"));
            Console.WriteLine(HoiC.Count);


            for (int i = 1; i < HoiC.Count; i++)
            {

                String s = "//*[@id='homepage-dropdown-menu']/li[" + i + "]/a";

                By loc = By.XPath(s);
                //  WaitForElement(loc);
                IWebElement TitleOfHolidayCollection = driver.FindElement(By.XPath(s));
                var Holiday = TitleOfHolidayCollection.Text;
                Wait();

                Console.WriteLine(Holiday);

            }

        }

        public int CountHolidayCollections()
        {
            IList<IWebElement> HolC = driver.FindElements(By.XPath(@"//*[@id='homepage-dropdown-menu']/li"));
            Console.WriteLine(HolC.Count);
            return HolC.Count;
        }

        public static void ClickCollections(string p0)
        {
            Console.WriteLine(p0);
            IList<IWebElement> HoiC = driver.FindElements(By.XPath(@"//*[@id='homepage-dropdown-menu']/li"));
            Console.WriteLine(HoiC.Count);


            for (int i = 1; i < HoiC.Count; i++)
            {

                String p = "//*[@id='homepage-dropdown-menu']/li[" + i + "]/a";



                IWebElement TitleOfTheDestination1 = driver.FindElement(By.XPath(p));
                var city1 = TitleOfTheDestination1.Text;
                Console.WriteLine("*****************************");
                WaitforElement();

                Console.WriteLine(city1);
                if (p0.Equals(city1))
                {
                    TitleOfTheDestination1.Click();
                    Console.WriteLine("*****************************");
                    WaitforElement();
                    Console.WriteLine("**********************");
                    Console.WriteLine(driver.Title);





                    break;

                }




            }





        }

        private static WebDriverWait WaitforElement()
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public static void TitleContains(string p0)
        {
            String St = driver.Title;
            Console.WriteLine(driver.Title);



        }
    }
}

