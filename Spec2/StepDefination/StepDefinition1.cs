using AventStack.ExtentReports.Gherkin.Model;
using System;
using TechTalk.SpecFlow;

namespace Spec2.Properties
{
    [Binding]
    public sealed class StepDefinition1
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            Console.WriteLine("Entered" + number);
        }
        [When("I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("wHEN");
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            Console.WriteLine("Same" + result);
        }

    
    }
}
