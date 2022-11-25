

namespace Login_Test_Automation_TurnUp.EmployeeFolder;

public class EmployeesPage : findByLocator
{
    public void gotoEmployeePage(IWebDriver chromeDriver)
    {
        turnUpPortalBaseClass baseClass = new();
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Employees')]", FindBy.XPath).Click();
    }
}
