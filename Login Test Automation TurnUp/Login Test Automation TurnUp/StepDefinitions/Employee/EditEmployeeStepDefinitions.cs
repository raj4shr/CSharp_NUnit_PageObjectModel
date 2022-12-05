using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;


namespace Login_Test_Automation_TurnUp.StepDefinitions.Employee
{
    [Binding]
    public class EditEmployeeStepDefinitions : WebDriver
    {

        EditEmployeePage? editEmployee;
        WebDriver? wd;

        public EditEmployeeStepDefinitions(ScenarioContext scenarioContext)
        {
            wd = (WebDriver)scenarioContext["driver"];
        }

        [When(@"I have edited a employee record '([^']*)' with respective '([^']*)'")]
        public void WhenIHaveEditedAEmployeeRecordWithRespective(string userName, string row)
        {
            editEmployee = new();
            editEmployee.editEmployee(wd.chromeDriver, userName, int.Parse(row));
        }

        [Then(@"Employee record '([^']*)' should be edited successfully withrespect to the relavent '([^']*)'")]
        public void ThenEmployeeRecordShouldBeEditedSuccessfullyWithrespectToTheRelavent(string userName, string row)
        {
            editEmployee.verifyEmployeeEdit(wd.chromeDriver, userName, int.Parse(row));
            wd.chromeDriver.Quit();
        }
    }
}
