using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;


namespace Login_Test_Automation_TurnUp.StepDefinitions.Employee
{
    [Binding]
    public partial class Employee_StepDefinitions : WebDriver
    {
        CreateNewEmployeePage? newEmployee;
        ISpecFlowOutputHelper? _outputHelper;
        EmployeeDeletePage employeeDelete;
        EmployeeDragAndDropPage? employeeDAD;
        EditEmployeePage? editEmployee;

        //Specflow output helper injection
        public Employee_StepDefinitions(ISpecFlowOutputHelper outputHelper)
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
    }
}
