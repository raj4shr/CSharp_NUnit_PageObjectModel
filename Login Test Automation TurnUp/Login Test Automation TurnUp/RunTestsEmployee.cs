
using Login_Test_Automation_TurnUp.EmployeeFolder;

namespace Login_Test_Automation_TurnUp;
[TestFixture]
public class RunTestsEmployee : SetupCommonClassFolder.WebDriver
{
    
    [Test]
    public void CreateNewEmployee()
    {
        EmployeesPage employee = new();
        employee.gotoEmployeePage(chromeDriver);
        CreateNewEmployeePage CNEP = new();
        CNEP.CreateNewEmployee(chromeDriver);
    }

    [Test]
    public void DeleteEmployee()
    {
        EmployeesPage employee = new();
        employee.gotoEmployeePage(chromeDriver);
        EmployeeDeletePage EDP = new();
        EDP.DeleteEmployee(chromeDriver);
    }

    [Test]
    public void EditEmployeePage()
    {
        EmployeesPage employee = new();
        employee.gotoEmployeePage(chromeDriver);
        EditEmployeePage EEP = new();
        EEP.editEmployee(chromeDriver);
    }

    [Test]
    public void DragAndDrop()
    {
        EmployeesPage employee = new();
        employee.gotoEmployeePage(chromeDriver);
        EmployeeDragAndDropPage EPDAD = new();
        EPDAD.dragAnddropEmployee(chromeDriver);
    }

    [Test]
    public void DragAndDropClose()
    {
        EmployeesPage employee = new();
        employee.gotoEmployeePage(chromeDriver);
        EmployeeDragAndDropPage EDAD = new();
        EDAD.dragAnddropClose(chromeDriver);
    }

   
}
