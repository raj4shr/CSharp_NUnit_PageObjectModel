using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;

namespace Login_Test_Automation_TurnUp.StepDefinitions.Employee
{
    [Binding]
    public class CreateANewEmployeeStepDefinitions : WebDriver
    {
        CreateNewEmployeePage? newEmployee;
        ISpecFlowOutputHelper? _outputHelper;

        //Specflow output helper injection
        public CreateANewEmployeeStepDefinitions(ISpecFlowOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoEmployeePortalSuccessfully()
        {
            _outputHelper.WriteLine("Specflow BDD for logging in to IC portal");
            WebDriver wd = new();
            wd.login();
        }

        [When(@"I navigate to the employees page")]
        public void WhenINavigateToTheEmployeesPage()
        {
            EmployeesPage employee = new();
            employee.gotoEmployeePage(chromeDriver);
            _outputHelper.WriteLine("Specflow BDD to navigating to the employees page");
        }

        [When(@"I have created a new employee record")]
        public void WhenIHaveCreatedANewEmployeeRecord()
        {
            newEmployee = new();
            newEmployee.CreateNewEmployee(chromeDriver);
        }

        [Then(@"A new employee should be created sucessfully")]
        public void ThenANewEmployeeShouldBeCreatedSucessfully()
        {
            newEmployee.CheckCreatedEmployee(chromeDriver);
            chromeDriver.Quit();
        }
    }
}
