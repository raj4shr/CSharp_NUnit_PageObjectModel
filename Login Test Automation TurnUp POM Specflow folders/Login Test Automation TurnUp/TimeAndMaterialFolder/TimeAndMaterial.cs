namespace Login_Test_Automation_TurnUp.Pages;

public class TimeAndMaterial : findByLocator
{
    public void gotoTimeAndMaterial(IWebDriver chromeDriver)
    {
        //Finding and clicking on time and material item from the administration menu
        turnUpPortalBaseClass baseClass = new();
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Time & Materials')]", FindBy.XPath).Click();
    }


}
