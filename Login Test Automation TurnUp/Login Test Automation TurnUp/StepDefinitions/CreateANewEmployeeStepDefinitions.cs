using TechTalk.SpecFlow;
using Login_Test_Automation_TurnUp.EmployeeFolder;
using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;

namespace Login_Test_Automation_TurnUp.StepDefinitions
{
    [Binding]
    public class CreateANewEmployeeStepDefinitions : WebDriver
    {
        CreateNewEmployeePage? newEmployee;

        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoEmployeePortalSuccessfully()
        {
            WebDriver wd = new();
            wd.login();
        }

        [When(@"I navigate to the employees page")]
        public void WhenINavigateToTheEmployeesPage()
        {
            EmployeesPage employee = new();
            employee.gotoEmployeePage(chromeDriver);
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
