using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace Login_Test_Automation_TurnUp;

public class DragAndDrop : findByLocator
{
    public void dragAnddrop(IWebDriver chromeDriver)
    {
        turnUpPortalBaseClass baseClass = new();
        //selenium actions class object created for drag and drop operation
        Actions builder = new Actions(chromeDriver);
        builder.DragAndDrop(baseClass.findElementOnPage(chromeDriver, "//th[@data-field='Code']", FindBy.XPath), baseClass.findElementOnPage(chromeDriver, "//div[contains(text(),'Drag a column header and drop it here to group by that column')]", FindBy.XPath)).Perform();
        Assert.Pass();
    }
}
