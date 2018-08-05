using TechTalk.SpecFlow;

namespace Spec2.Properties
{
    [Binding]
    public sealed class ExtendedSteps
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        public readonly EmployeeDetails employee;
        public ExtendedSteps(EmployeeDetails emp)
        {
            this.employee = emp;
        }
    }

   
}