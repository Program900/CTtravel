using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Spec2.Pages;
using Spec2.Properties;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Spec2 
{
    [Binding]
    public class LoginSteps
    {

        BasePage basePage;
        public LoginSteps(BasePage basePage)
        {
            this.basePage = basePage;
        }

        
        [Given(@"I navigate to login")]
        public void GivenINavigateToLogin()
        {
            Console.WriteLine("Given");
            basePage.openURL();


        }
        
        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            Console.WriteLine("When");
           
                }
        
        [Then(@"I should see user logged in")]
        public void ThenIShouldSeeUserLoggedIn()
        {
            Console.WriteLine("Then");
            

        }
        

        [When(@"I enter (.*) and (.*)")]
        public void WhenIEnterAnd(string aD0, string as1)
        {
            Console.WriteLine(aD0, as1);
            Thread.Sleep(2000);
            
        }

       
    }
}
