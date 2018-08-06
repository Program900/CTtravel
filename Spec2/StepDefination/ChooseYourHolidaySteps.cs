using Spec2.StepDefination;
using System;
using TechTalk.SpecFlow;
using Spec2.Pages;
using NUnit.Framework;
using Spec2.Data;

namespace Spec2
{
    [Binding]
    public class ChooseYourHolidaySteps : BaseSteps
    {
        HomePage homePage;
        BasePage basePage;
        TestData testData;
        HolidayCollectionsPage holidayCollectionsPage;



        ChooseYourHolidaySteps(HomePage homePage, BasePage basePage, TestData testData, HolidayCollectionsPage holidayCollectionsPage)
        {
            this.homePage = homePage;
            this.basePage = basePage;
            this.holidayCollectionsPage = holidayCollectionsPage;
            this.testData = testData;
        }

        [Given(@"I open HolidayCollections")]
        public void GivenIOpenHolidayCollections()
        {
            homePage.ClickHoidayCollections();

        }

        [Given(@"I am on HolidayCollections")]
        public void GivenIAmOnHolidayCollections()
        {

            String ActualTitle = holidayCollectionsPage.HolidayCollectionsPageTitle();
            String ExpectedTitle = holidayCollectionsPage.HolidayCollectionsPageExpectedTitle();
            Assert.AreEqual(ActualTitle, ExpectedTitle);
        }
        [Given(@"I have ChooseAHolidayCollection")]
        public void GivenIHaveChooseAHolidayCollection()
        {
            bool C = holidayCollectionsPage.IsChooseAHolidayCollection();
            Assert.IsTrue(C);
        }
        [When(@"I click on ChooseHolidayCollection")]
        public void WhenIClickOnChooseHolidayCollection()
        {
            holidayCollectionsPage.ClickHolidayCollection();
        }


        [When(@"I select  HolidayCollection")]
        public void WhenISelectHolidayCollection()
        {
            holidayCollectionsPage.ClickHolidayCollection();
        }

        [Then(@"I should see selected HolidayCollection")]
        public void ThenIShouldSeeSelectedDestination()
        {
            Console.WriteLine("Given");
        }



        [Then(@"I should see OptionsofHolidayCollection")]
        public void ThenIShouldSeeOptionsofHolidayCollection()
        {
            holidayCollectionsPage.OptionsOfHolidayCollections();
        }



        [Then(@"I should see '(.*)' HolidayCollection")]
        public void ThenIShouldSeeHolidayCollection(int p0)
        {
            int ActualCount = holidayCollectionsPage.CountHolidayCollections();
            int ExpectedCount = p0;
            Assert.AreEqual(ActualCount, ExpectedCount);
        }

        [When(@"I click on '(.*)'")]
        public void WhenIClickOn(string p0)
        {
            Console.WriteLine(p0);
            HolidayCollectionsPage.ClickCollections(p0);
        }


        [Then(@"I should see selected '(.*)'")]
        public void ThenIShouldSeeSelected(string p0)
        {
            Console.WriteLine(p0);
            HolidayCollectionsPage.TitleContains(p0);
        }


    }
}
