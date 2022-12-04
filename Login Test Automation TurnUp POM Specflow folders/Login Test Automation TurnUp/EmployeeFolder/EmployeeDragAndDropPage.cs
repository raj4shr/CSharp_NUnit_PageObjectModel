using static Login_Test_Automation_TurnUp.findByLocator;

namespace Login_Test_Automation_TurnUp.EmployeeFolder;

public class EmployeeDragAndDropPage
{
    private turnUpPortalBaseClass? baseClass;
    public void dragAnddropEmployee(IWebDriver chromeDriver)
    {
        baseClass = new();
        //selenium actions class object created for drag and drop operation
        Actions builder = new Actions(chromeDriver);
        Thread.Sleep(3000);
        //Getting the drag and drop source and destination
        IWebElement elementSource = baseClass.findElementOnPage(chromeDriver, "//a[starts-with(text(),'Name')]", FindBy.XPath);
        IWebElement elementDestination = baseClass.findElementOnPage(chromeDriver, "//div[contains(text(),'Drag a column header and drop it here to group by that column')]", FindBy.XPath);
        //Executing drag and drop operation
        builder.DragAndDrop(elementSource, elementDestination).Perform();

    }

    public void dragAnddropCloseBDD(IWebDriver chromeDriver)
    {
        //Finding and clicking the drag and drop tab close button
        baseClass.findElementOnPageClickable(chromeDriver, "//span[@class='k-icon k-group-delete']", FindBy.XPath).Click();

    }

}
