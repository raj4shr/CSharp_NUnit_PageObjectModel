using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;
namespace Login_Test_Automation_TurnUp.Pages;

public class NewTimeAndMaterial : findByLocator
{
    private turnUpPortalBaseClass? baseClass;
    string str = "";
   

    public NewTimeAndMaterial()
    {
        baseClass = new();
    }

   

    public void createNewTandM(IWebDriver chromeDriver)
    {
        //Finding and clicking the create new button
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Create New')]", FindBy.XPath).Click();
        //Generating a random code for input code value in the element
        str = baseClass.phoneRand();
        baseClass.findElementOnPage(chromeDriver, "Code", FindBy.Id).SendKeys(str);
        //Finding and inputting rest of the elements
        baseClass.findElementOnPage(chromeDriver, "Description", FindBy.Id).SendKeys("This record is new");
        baseClass.findElementOnPage(chromeDriver, "//input[@class='k-formatted-value k-input']", FindBy.XPath).SendKeys("100");
        //Finding and clicking the save button
        baseClass.findElementOnPage(chromeDriver, "SaveButton", FindBy.Id).Click();
        Thread.Sleep(3000);
    }

    public void checkNewTimeAndMaterialCreated(IWebDriver chromeDriver)
    {
        bool created=false;
        //Finding and clicking the goto last button
        baseClass.findElementOnPage(chromeDriver, "//a[@title='Go to the last page'][@class='k-link k-pager-nav k-pager-last']", FindBy.XPath).Click();
        //Getting all the rows from the data table to check if new time and material record has been created
        ReadOnlyCollection<IWebElement> rows = baseClass.findElementsOnPage(chromeDriver, "//tr[@role='row']", FindBy.XPath);
        ReadOnlyCollection<IWebElement>? cols;
        for (int i = 0; i < rows.Count; i++)
        {
            cols = rows[i].FindElements(By.TagName("td"));
            if (cols[0].Text == str)
            {
                created = true;
            }
        }
        Assert.That(created, Is.True,"Time and Material record has not been created");
    }
}
