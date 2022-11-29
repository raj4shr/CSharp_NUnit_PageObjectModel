
using Login_Test_Automation_TurnUp.EmployeeFolder;

namespace Login_Test_Automation_TurnUp;
[TestFixture]
public class RunTestsEmployee : SetupCommonClassFolder.WebDriver
{
    
    [Test,Order(1)]
    public void CreateNewEmployee()
    {
        EmployeesPage employee = new();
        employee.gotoEmployeePage(chromeDriver);
        CreateNewEmployeePage CNEP = new();
        CNEP.CreateNewEmployee(chromeDriver);
        CNEP.CheckCreatedEmployee(chromeDriver);
    }

    [Test,Order(3)]
    public void DeleteEmployee()
    {
        EmployeesPage employee = new();
        employee.gotoEmployeePage(chromeDriver);
        EmployeeDeletePage EDP = new();
        EDP.DeleteEmployee(chromeDriver);
    }

    [Test,Order(2)]
    public void EditEmployeePage()
    {
        EmployeesPage employee = new();
        employee.gotoEmployeePage(chromeDriver);
        EditEmployeePage EEP = new();
        EEP.editEmployee(chromeDriver);
    }

    [Test,Order(4)]
    public void DragAndDrop()
    {
        EmployeesPage employee = new();
        employee.gotoEmployeePage(chromeDriver);
        EmployeeDragAndDropPage EPDAD = new();
        EPDAD.dragAnddropEmployee(chromeDriver);
    }

    [Test,Order(5)]
    public void DragAndDropClose()
    {
        EmployeesPage employee = new();
        employee.gotoEmployeePage(chromeDriver);
        EmployeeDragAndDropPage EDAD = new();
        EDAD.dragAnddropClose(chromeDriver);
    }

   
}
