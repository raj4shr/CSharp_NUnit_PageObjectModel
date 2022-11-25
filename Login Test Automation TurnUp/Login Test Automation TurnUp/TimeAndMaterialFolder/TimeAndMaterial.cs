
namespace Login_Test_Automation_TurnUp.Pages;

public class TimeAndMaterial : findByLocator
{
    public void gotoTimeAndMaterial(IWebDriver chromeDriver)
    {
        turnUpPortalBaseClass baseClass = new();
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Time & Materials')]", FindBy.XPath).Click();
    }


}
