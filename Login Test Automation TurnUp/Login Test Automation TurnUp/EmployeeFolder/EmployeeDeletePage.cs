

namespace Login_Test_Automation_TurnUp.EmployeeFolder;

public class EmployeeDeletePage : findByLocator
{
    public void DeleteEmployee(IWebDriver chromeDriver)
    {
        Thread.Sleep(2000);
        turnUpPortalBaseClass baseClass = new();
        baseClass.findElementsOnPage(chromeDriver, "//a[@class='k-button k-button-icontext k-grid-Delete']", FindBy.XPath)[4].Click();
        Thread.Sleep(2000);
        chromeDriver.SwitchTo().Alert().Accept();
    }
}
