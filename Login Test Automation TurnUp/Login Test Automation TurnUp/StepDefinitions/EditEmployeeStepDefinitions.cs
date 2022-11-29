using TechTalk.SpecFlow;
using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;
using Login_Test_Automation_TurnUp.EmployeeFolder;

namespace Login_Test_Automation_TurnUp.StepDefinitions
{
    [Binding]
    public class EditEmployeeStepDefinitions : WebDriver
    {

        EditEmployeePage? editEmployee;
        [When(@"I have edited a employee record")]
        public void WhenIHaveEditedAEmployeeRecord()
        {
            editEmployee = new();
            editEmployee.editEmployee(chromeDriver);
        }

        [Then(@"Employee record should be edited successfully")]
        public void ThenEmployeeRecordShouldBeEditedSuccessfully()
        {
            Console.WriteLine("Record Edited");
            chromeDriver.Quit();
        }

    }
}
