using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;

namespace Login_Test_Automation_TurnUp.StepDefinitions.Employee
{
    [Binding]
    public class DeleteEmployeeStepDefinitions : WebDriver
    {
        EmployeeDeletePage employeeDelete;
        WebDriver? wd;

        public DeleteEmployeeStepDefinitions(ScenarioContext scenarioContext)
        {
            wd = (WebDriver)scenarioContext["driver"];
        }

        [When(@"I have deleted an employee record")]
        public void WhenIHaveDeletedAnEmployeeRecord()
        {
            employeeDelete = new();
            employeeDelete.DeleteEmployee(wd.chromeDriver);

        }

        [Then(@"Employee record should be deleted successfully")]
        public void ThenEmployeeRecordShouldBeDeletedSuccessfully()
        {
            wd.chromeDriver.Quit();
        }

    }
}
