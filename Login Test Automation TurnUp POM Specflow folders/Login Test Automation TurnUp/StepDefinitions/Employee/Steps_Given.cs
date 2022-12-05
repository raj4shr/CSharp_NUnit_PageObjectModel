using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;

[assembly:Parallelizable(ParallelScope.Fixtures)]
namespace Login_Test_Automation_TurnUp.StepDefinitions.Employee
{
    
    [Binding]
    public partial class Employee_StepDefinitions : WebDriver
    {

        CreateNewEmployeePage? newEmployee;
        EmployeeDeletePage? employeeDelete;
        EmployeeDragAndDropPage? employeeDAD;
        EditEmployeePage? editEmployee;
        WebDriver? wd;

        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoEmployeePortalSuccessfully()
        {
            wd = new();
            wd.login();
        }

    }
}
