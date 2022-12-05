namespace Login_Test_Automation_TurnUp.EmployeeFolder;

public class EmployeesPage : findByLocator
{
    public void gotoEmployeePage(IWebDriver chromeDriver)
    {
        turnUpPortalBaseClass baseClass = new();
        //Finding and clicking the employees tab in administration menu
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Employees')]", FindBy.XPath).Click();
    }
}
