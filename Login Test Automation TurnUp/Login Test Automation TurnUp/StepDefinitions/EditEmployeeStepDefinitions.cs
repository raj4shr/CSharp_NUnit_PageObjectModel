using TechTalk.SpecFlow;
using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;
using Login_Test_Automation_TurnUp.EmployeeFolder;

namespace Login_Test_Automation_TurnUp.StepDefinitions
{
    [Binding]
    public class EditEmployeeStepDefinitions : WebDriver
    {

        EditEmployeePage? editEmployee;

       /* [When(@"I have edited a employee record")]
        public void WhenIHaveEditedAEmployeeRecord()
        {
            editEmployee = new();
            editEmployee.editEmployee(chromeDriver);
        }*/

      

        [When(@"I have edited a employee record '([^']*)' with respective '([^']*)'")]
        public void WhenIHaveEditedAEmployeeRecordWithRespective(string userName, string row)
        {
            editEmployee = new();
            editEmployee.editEmployee(chromeDriver,userName,int.Parse(row));
        }

        [Then(@"Employee record '([^']*)' should be edited successfully withrespect to the relavent '([^']*)'")]
        public void ThenEmployeeRecordShouldBeEditedSuccessfullyWithrespectToTheRelavent(string userName, string row)
        {
            editEmployee.verifyEmployeeEdit(chromeDriver, userName, int.Parse(row));
            chromeDriver.Quit();
        }

        /*[Then(@"Employee record should be edited successfully")]
        public void ThenEmployeeRecordShouldBeEditedSuccessfully()
        {
            Console.WriteLine("Record Edited");
            chromeDriver.Quit();
        }*/

    }
}
