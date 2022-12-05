using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;

namespace Login_Test_Automation_TurnUp.StepDefinitions.Employee
{
    [Binding]
    public class EmployeeDragAnd_DropStepDefinitions : WebDriver
    {
        EmployeeDragAndDropPage? employeeDAD;
        WebDriver? wd;

        public EmployeeDragAnd_DropStepDefinitions(ScenarioContext scenarioContext)
        {
            wd = (WebDriver)scenarioContext["driver"];
        }
        [When(@"I have dragged and dropped a column tab")]
        public void WhenIHaveDraggedAndDroppedAColumnTab()
        {
            employeeDAD = new();
            employeeDAD.dragAnddropEmployee(wd.chromeDriver);
        }

        [Then(@"the employee page should be sorted successfully")]
        public void ThenTheEmployeePageShouldBeSortedSuccessfully()
        {
            Thread.Sleep(3000);
            employeeDAD.dragAnddropCloseBDD(wd.chromeDriver);
            wd.chromeDriver.Quit();
        }

    }
}
