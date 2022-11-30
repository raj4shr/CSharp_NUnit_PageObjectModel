
namespace Login_Test_Automation_TurnUp.SetupCommonClassFolder;

public class PortalLogin : findByLocator
{

    public PortalLogin(IWebDriver chromeDriver)
    {
        //Code to login to industry connect portal and clicking on the administration menu item to access employee and timematerial tabs
        chromeDriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        chromeDriver.Manage().Window.Maximize();
        turnUpPortalBaseClass baseClass = new turnUpPortalBaseClass();
        baseClass.findElementOnPage(chromeDriver, "UserName", FindBy.Id).SendKeys("hari");
        baseClass.findElementOnPage(chromeDriver, "Password", FindBy.Id).SendKeys("123123");
        baseClass.findElementOnPage(chromeDriver, "//input[contains(@value,'Log in')]", FindBy.XPath).Click();
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Administration')]", FindBy.XPath).Click();
    }

}