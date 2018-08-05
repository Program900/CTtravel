using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spec2.Pages
{
    public class HomePage :BasePage
    {
        private String pageTitle = "Tailor Made Holidays, Luxury Travel and Tours with Pettitts";

        
        public HomePage()
        {

        }
        public String  HomePageActualTitle()
        {
            Wait();
            Console.WriteLine("Title");
           Console.WriteLine(driver.Title);
            return driver.Title;
        }
        public String HomePageExpectedTitle()
        {
            return pageTitle;
        }

        public bool IsChooseyourDestination()
        {
           // List<IWebElement> e = driver.FindElements(By.XPath(@"//*[@id='content']/div[2]/div[2]/div/div[1]/div[2]/div/div/button[2]"));
            if (IsElementPresent(By.XPath(@"//*[@id='content']/div[2]/div[2]/div/div[1]/div[2]/div/div/button[2]")))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public int CountDestination()
        {
            IList<IWebElement> des = driver.FindElements(By.XPath(@"//*[@id='homepage-dropdown-menu']/li"));
            Console.WriteLine(des.Count);
            return des.Count;
            
        }

            public  void OptionsOfDestination()
        {
          IList<IWebElement>des= driver.FindElements(By.XPath(@"//*[@id='homepage-dropdown-menu']/li"));
            Console.WriteLine(des.Count);
           

            for (int i = 1; i < des.Count; i++)
            {

               String s= "//*[@id='homepage-dropdown-menu']/li["+i+"]/a";
                IWebElement TitleOfTheDestination =  driver.FindElement(By.XPath(s));
               var city= TitleOfTheDestination.Text;
                Console.WriteLine(city);
                
            }
        }

        public void SelectDestination()
        {
            String s = "//*[@id='homepage-dropdown-menu']/li[2]/a";
            IWebElement TitleOfTheDestination = driver.FindElement(By.XPath(s));
            var city = TitleOfTheDestination.Text;
            Console.WriteLine(city);
            TitleOfTheDestination.Click();
            Console.WriteLine(driver.Title);



        }

        public bool IsSelectedDestination()
        {
            Console.WriteLine(driver.Title);
            String ActualTitle = driver.Title;
            String ExpectedTitle = "Armenia Holidays - Luxury Travel & Tailor Made Tours 2018/2019";
            if (ActualTitle.Equals(ExpectedTitle)) {

            
                return true;
            }
            else
            {
                return false;
            }

        }

        public void ClickDestination()
        {
            IWebElement ClickDestination = driver.FindElement(By.XPath(@"//*[@id='content']/div[2]/div[2]/div/div[1]/div[2]/div/div/button[2]"));

            ClickDestination.Click();
            Wait();
        }

        public  void ClickHoidayCollections()
        {
            IWebElement HolidayCollections = driver.FindElement(By.LinkText("Holiday Collections"));
            HolidayCollections.Click();
            
      
        }

        
    }
}
