

namespace Login_Test_Automation_TurnUp.EmployeeFolder;

public class CreateNewEmployeePage : findByLocator
{
    public void CreateNewEmployee(IWebDriver chromeDriver)
    {
        turnUpPortalBaseClass baseClass = new();
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Create')]", FindBy.XPath).Click();
        baseClass.findElementOnPage(chromeDriver, "Name", FindBy.Id).SendKeys("Kratos");
        baseClass.findElementOnPage(chromeDriver, "Username", FindBy.Id).SendKeys("Kratos2022");
        baseClass.findElementOnPage(chromeDriver, "ContactDisplay", FindBy.Id).SendKeys(" Kratos GodOfWar 1234567 GodOfWar2022@santamonica.com");
        baseClass.findElementOnPage(chromeDriver, "Password", FindBy.Id).SendKeys("123asdA#");
        baseClass.findElementOnPage(chromeDriver, "RetypePassword", FindBy.Id).SendKeys("123asdA#");
        Thread.Sleep(2000);
        baseClass.findElementOnPage(chromeDriver, "SaveButton", FindBy.Id).Click();
    }
}


