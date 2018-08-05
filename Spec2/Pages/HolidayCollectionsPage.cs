using OpenQA.Selenium;
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

        public  void ClickHolidayCollection()
        {
            IWebElement HolidayCollections = driver.FindElement(By.XPath(@"//*[@id='content']/div[2]/div[3]/div[1]/div/div/button[2]"));
            HolidayCollections.Click();
            Wait();
        }

        public  bool IsChooseAHolidayCollection()
        {
            if(IsElementPresent(By.XPath(@"//*[@id='content']/div[2]/div[3]/div[1]/div/div/button[2]")))
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

                String s = "//*[@id='homepage-dropdown-menu']/li["+i+"]/a";
                By Collec = By.XPath(s);
                
                WaitForElement(Collec);
                IWebElement TitleOfHolidayCollection = driver.FindElement(By.XPath(s));
                var Holiday = TitleOfHolidayCollection.Text;
                
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
            IList<IWebElement> HoiC = driver.FindElements(By.XPath(@"//*[@id='homepage-dropdown-menu']/li"));
            Console.WriteLine(HoiC.Count);


            for (int i = 1; i < HoiC.Count; i++)
            {

                String s = "//*[@id='homepage-dropdown-menu']/li["+i+"]/a";
                By Collec = By.XPath(s);

               // WaitForElement(Collec);
                IWebElement TitleOfHolidayCollection = driver.FindElement(By.XPath(s));
                var Holiday = TitleOfHolidayCollection.Text;
                if (Holiday == p0)
                {
                    TitleOfHolidayCollection.Click();
                    break;
                    

                }
               // Wait();

                Console.WriteLine(Holiday);
                Console.WriteLine(driver.Title);
            }
        }

        public void Sp(string p0)
        {
            throw new NotImplementedException();
        }
    }
}

