using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;


namespace Login_Test_Automation_TurnUp.StepDefinitions.Employee
{
    public partial class Employee_StepDefinitions
    {
        
        [When(@"I have deleted an employee record")]
        public void WhenIHaveDeletedAnEmployeeRecord()
        {
            employeeDelete = new();
            employeeDelete.DeleteEmployee(chromeDriver);

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

        
        [When(@"I have dragged and dropped a column tab")]
        public void WhenIHaveDraggedAndDroppedAColumnTab()
        {
            employeeDAD = new();
            employeeDAD.dragAnddropEmployee(chromeDriver);
        }

        

        [When(@"I have edited a employee record '([^']*)' with respective '([^']*)'")]
        public void WhenIHaveEditedAEmployeeRecordWithRespective(string userName, string row)
        {
            editEmployee = new();
            editEmployee.editEmployee(chromeDriver, userName, int.Parse(row));
        }
    }
}
