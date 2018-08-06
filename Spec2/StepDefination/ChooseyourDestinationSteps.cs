using NUnit.Framework;
using Spec2.Data;
using Spec2.Pages;
using Spec2.StepDefination;
using System;
using TechTalk.SpecFlow;

namespace Spec2
{
    [Binding]
    public class ChooseyourDestinationSteps:BaseSteps

    {

        HomePage homePage;
        BasePage basePage;
        TestData testData;

        ChooseyourDestinationSteps(HomePage homePage, BasePage basePage, TestData testData)
        {
            this.homePage = homePage;
            this.basePage = basePage;

            this.testData = testData;


        }

        [Given(@"I am on HomePage")]
        public void GivenIAmOnHomePage()
        {
            basePage.openURL();
            String ActualTitle = homePage.HomePageActualTitle();
            String ExpectedTitle = homePage.HomePageExpectedTitle();
            Assert.AreEqual(ActualTitle, ExpectedTitle);
        }

        
        [Given(@"I click on ChooseyourDestination")]
        public void GivenIClickOnChooseyourDestination()
        {
            homePage.ClickDestination();
        }

        [Given(@"I have  ChooseyourDestination")]
        public void GivenIHaveChooseyourDestination()
        {
            Console.WriteLine("Given");
            bool b = homePage.IsChooseyourDestination();
            Assert.IsTrue(b);

        }

        [When(@"I click on ChooseyourDestination")]
        public void WhenIClickOnChooseyourDestination()
        {
            homePage.ClickDestination();

        }
        [When(@"I select any ChooseyourDestination")]
        public void WhenISelectAnyChooseyourDestination()
        {
            homePage.SelectDestination();
        }
        [Then(@"I should see '(.*)' Destination")]
        public void ThenIShouldSeeHolidayCollection(int p0)
        {
            int ActualCount = homePage.CountDestination();
            int ExpectedCount = p0;
            Assert.AreEqual(ActualCount, ExpectedCount);
        }

        

        [Then(@"I should see OptionsOfDestinationCollection")]
        public void ThenIShouldSeeOptionsOfDestinationCollection()
        {
            homePage.OptionsOfDestination();
        }

        [Then(@"I should see selected ChooseyourDestination")]
        public void ThenIShouldSeeSelectedHolidayCollection()
        {
           bool selected= homePage.IsSelectedDestination();
            Assert.IsTrue(selected);
        }

       
    }
}
