




namespace Login_Test_Automation_TurnUp;

public class DragAndDrop : findByLocator
{
    public void dragAnddrop(IWebDriver chromeDriver)
    {
        turnUpPortalBaseClass baseClass = new();
        //selenium actions class object created for drag and drop operation
        Actions builder = new Actions(chromeDriver);
        Thread.Sleep(3000);
        IWebElement elementSource = baseClass.findElementOnPage(chromeDriver, "//a[starts-with(text(),'Code')]", FindBy.XPath);
        IWebElement elementDestination = baseClass.findElementOnPage(chromeDriver,"//div[contains(text(),'Drag a column header and drop it here to group by that column')]", FindBy.XPath);
        builder.DragAndDrop(elementSource, elementDestination).Perform();
 
    }

    public void dragAnddropClose(IWebDriver chromeDriver)
    {
        turnUpPortalBaseClass baseClass = new();
        //selenium actions class object created for drag and drop operation
        Actions builder = new Actions(chromeDriver);
        IWebElement elementSource = baseClass.findElementOnPage(chromeDriver, "//a[starts-with(text(),'Code')]", FindBy.XPath);
        IWebElement elementDestination = baseClass.findElementOnPage(chromeDriver, "//div[contains(text(),'Drag a column header and drop it here to group by that column')]", FindBy.XPath);
        builder.DragAndDrop(elementSource, elementDestination).Perform();
        Thread.Sleep(1000);
        baseClass.findElementOnPageClickable(chromeDriver, "//span[@class='k-icon k-group-delete']", FindBy.XPath).Click();

    }

    public void dragAnddropCloseBDD(IWebDriver chromeDriver)
    {
        turnUpPortalBaseClass baseClass = new();
        baseClass.findElementOnPageClickable(chromeDriver, "//span[@class='k-icon k-group-delete']", FindBy.XPath).Click();

    }
}
