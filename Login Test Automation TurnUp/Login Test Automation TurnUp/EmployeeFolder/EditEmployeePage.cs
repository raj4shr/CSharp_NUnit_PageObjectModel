using static Login_Test_Automation_TurnUp.findByLocator;

namespace Login_Test_Automation_TurnUp.EmployeeFolder;

public class EditEmployeePage
{
    private turnUpPortalBaseClass? baseClass;

    public EditEmployeePage()
    {
        baseClass = new();
    }
    public void editEmployee(IWebDriver chromeDriver,string userName,int rowId)
    {
        Thread.Sleep(5000);
        //Finding and clicking the edit button
        baseClass.findElementsOnPage(chromeDriver, "//a[@class='k-button k-button-icontext k-grid-Edit'][contains(text(),'Edit')]", FindBy.XPath)[rowId].Click();
        //Finding the username text box and updating the value using outline scenario
        IWebElement element= baseClass.findElementOnPage(chromeDriver, "Username", FindBy.Id);
        element.Clear();
        element.SendKeys(userName);
        //Finding and clicking the save button after the edit
        baseClass.findElementOnPage(chromeDriver, "SaveButton", FindBy.Id).Click();
        //Finding and clicking the save to list hyperlink
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Back to List')]", FindBy.XPath).Click();
    }

    public void verifyEmployeeEdit(IWebDriver chromeDriver,string userName,int rowId)
    {
        //Storing all the rows in the table in a collection
        ReadOnlyCollection<IWebElement> rows = baseClass.findElementsOnPage(chromeDriver, "//tr[@role='row']", FindBy.XPath);
        string expectedUserName=userName;
        //Getting the value from the corresponding row identified by outline scenario
        string actualUserName = rows[rowId].FindElements(By.TagName("td"))[1].Text;
        Assert.That(expectedUserName == actualUserName, "The username was not updated by specflow scenario outline parameter");

    }
}
