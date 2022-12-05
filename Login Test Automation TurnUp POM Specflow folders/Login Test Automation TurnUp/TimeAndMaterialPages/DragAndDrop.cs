namespace Login_Test_Automation_TurnUp;

public class DragAndDrop : findByLocator
{
    private turnUpPortalBaseClass? baseClass;
    public void dragAnddrop(IWebDriver chromeDriver)
    {
        baseClass = new();
        //selenium actions class object created for drag and drop operation
        Actions builder = new Actions(chromeDriver);
        Thread.Sleep(3000);
        //Getting drag and drop source and destination elements
        IWebElement elementSource = baseClass.findElementOnPage(chromeDriver, "//a[starts-with(text(),'Code')]", FindBy.XPath);
        IWebElement elementDestination = baseClass.findElementOnPage(chromeDriver,"//div[contains(text(),'Drag a column header and drop it here to group by that column')]", FindBy.XPath);
        //Performing drag and drop 
        builder.DragAndDrop(elementSource, elementDestination).Perform();
 
    }

    public void dragAnddropCloseBDD(IWebDriver chromeDriver)
    {
        baseClass = new();
        baseClass.findElementOnPageClickable(chromeDriver, "//span[@class='k-icon k-group-delete']", FindBy.XPath).Click();

    }
}
