using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;
[assembly: Parallelizable(ParallelScope.Fixtures)]
namespace Login_Test_Automation_TurnUp.StepDefinitions.Employee
{
    [Binding]
    public class CreateANewEmployeeStepDefinitions : WebDriver
    {
        CreateNewEmployeePage? newEmployee;
        ScenarioContext? _scenarioContext;
        WebDriver? wd;

        //Specflow output helper injection
        public CreateANewEmployeeStepDefinitions(ScenarioContext? scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoEmployeePortalSuccessfully()
        {
            wd = new();
            _scenarioContext.Add("driver", wd);
            wd.login();
        }

        [When(@"I navigate to the employees page")]
        public void WhenINavigateToTheEmployeesPage()
        {
            EmployeesPage employee = new();
            employee.gotoEmployeePage(wd.chromeDriver);
            
        }

        [When(@"I have created a new employee record")]
        public void WhenIHaveCreatedANewEmployeeRecord()
        {
            newEmployee = new();
            newEmployee.CreateNewEmployee(wd.chromeDriver);
        }

        [Then(@"A new employee should be created sucessfully")]
        public void ThenANewEmployeeShouldBeCreatedSucessfully()
        {
            newEmployee.CheckCreatedEmployee(wd.chromeDriver);
            wd.chromeDriver.Quit();
        }
    }
}
