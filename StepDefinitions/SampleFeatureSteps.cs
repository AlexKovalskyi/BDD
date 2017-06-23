using SpecflowDemo.StepDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowDemo.StepDefinitions
{
    [Binding]
    class SampleFeatureSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            Console.WriteLine(number);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Pressed add button.");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 120)//Grab the object whick has the value 120 un the UI and replace this
            {
                Console.WriteLine("the test passed");
            }
            else
            {
                Console.WriteLine("The test FAILED");
            }
        }

        [When(@"Ifill all the mandatory detail in form")]
        public void WhenIfillAllTheMandatoryDetailInForm(Table table)
        {
            var details = table.CreateSet<EmployeeDetails>();

            foreach (var item in details)
            {

                Console.WriteLine(item.Age);
                Console.WriteLine(item.Email);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Phone);
            }
        }
    }
}
