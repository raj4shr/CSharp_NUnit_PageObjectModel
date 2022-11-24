using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Login_Test_Automation_TurnUp.Pages;

public class PortalLogin : findByLocator
{
   
    public PortalLogin(IWebDriver chromeDriver)
    {
        chromeDriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        chromeDriver.Manage().Window.Maximize();
        turnUpPortalBaseClass baseClass = new turnUpPortalBaseClass();
        baseClass.findElementOnPage(chromeDriver, "UserName", FindBy.Id).SendKeys("hari");
        baseClass.findElementOnPage(chromeDriver, "Password", FindBy.Id).SendKeys("123123");
        baseClass.findElementOnPage(chromeDriver, "//input[contains(@value,'Log in')]", FindBy.XPath).Click();
    }

}