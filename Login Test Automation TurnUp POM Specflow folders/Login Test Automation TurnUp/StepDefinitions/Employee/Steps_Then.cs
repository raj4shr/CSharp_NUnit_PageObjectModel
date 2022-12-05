using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Test_Automation_TurnUp.StepDefinitions.Employee
{
    public partial class Employee_StepDefinitions 
    {
        [Then(@"A new employee should be created sucessfully")]
        public void ThenANewEmployeeShouldBeCreatedSucessfully()
        {
            newEmployee.CheckCreatedEmployee(wd.chromeDriver);
            wd.chromeDriver.Quit();
        }

        [Then(@"the employee page should be sorted successfully")]
        public void ThenTheEmployeePageShouldBeSortedSuccessfully()
        {
            Thread.Sleep(3000);
            employeeDAD.dragAnddropCloseBDD(wd.chromeDriver);
            wd.chromeDriver.Quit();
        }
        [Then(@"Employee record should be deleted successfully")]
        public void ThenEmployeeRecordShouldBeDeletedSuccessfully()
        {
            wd.chromeDriver.Quit();
        }

        [Then(@"Employee record '([^']*)' should be edited successfully withrespect to the relavent '([^']*)'")]
        public void ThenEmployeeRecordShouldBeEditedSuccessfullyWithrespectToTheRelavent(string userName, string row)
        {
            editEmployee.verifyEmployeeEdit(wd.chromeDriver, userName, int.Parse(row));
            wd.chromeDriver.Quit();
        }
    }
}
