using NUnit.Framework;
using OpenQA.Selenium;


namespace Login_Test_Automation_TurnUp.Pages;

public class DragAndDropClose : findByLocator
{

    public void closeDragandDrop(IWebDriver chromeDriver)
    {
        turnUpPortalBaseClass baseclass = new();
        Thread.Sleep(3000);
        baseclass.findElementOnPage(chromeDriver, "//span[@class='k-icon k-group-delete']", FindBy.XPath).Click();
        Assert.Pass();
    }

}
