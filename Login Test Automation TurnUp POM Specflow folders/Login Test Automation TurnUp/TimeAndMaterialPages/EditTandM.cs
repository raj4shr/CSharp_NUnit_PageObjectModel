namespace Login_Test_Automation_TurnUp.Pages;

public class EditTandM : findByLocator
{
    turnUpPortalBaseClass? baseClass;
    public void editTimeAndMaterial(IWebDriver chromeDriver)
    {
        //Thread.Sleep(5000);
        baseClass = new();
        Thread.Sleep(5000);
        //Finding and clicking the edit button on first row from the collection of rows in the data table
        baseClass.findElementsOnPage(chromeDriver, "//a[@class='k-button k-button-icontext k-grid-Edit'][contains(text(),'Edit')]", FindBy.XPath)[1].Click();
        //Finding all the input elements and updating the values
        baseClass.findElementOnPage(chromeDriver, "//span[@class='k-widget k-dropdown k-header text-box single-line'][@role='listbox']", FindBy.XPath).Click();
        baseClass.findElementOnPage(chromeDriver, "//li[@role='option'][contains(text(),'Material')]", FindBy.XPath).Click();
        baseClass.findElementOnPage(chromeDriver, "Code", FindBy.Id).Clear();
        baseClass.findElementOnPage(chromeDriver, "Code", FindBy.Id).SendKeys("Edited Successfully");
        baseClass.findElementOnPage(chromeDriver, "Description", FindBy.Id).Clear();
        baseClass.findElementOnPage(chromeDriver, "Description", FindBy.Id).SendKeys("This row has been edited using selenium code");
        //Finding and clicking on the overlapping element to access the price element(to clear the value)
        IWebElement element1= baseClass.findElementOnPage(chromeDriver, "//input[@type='text'][@class='k-formatted-value k-input']", FindBy.XPath);//clicking on overlapping element
        element1.Click();
        IWebElement element2= baseClass.findElementOnPage(chromeDriver, "Price", FindBy.Id);
        element2.Clear();
        //Finding and clicking on the overlapping element to access the price element(to update the value)
        element1.Click();
        Thread.Sleep(1000);
        element2.SendKeys("1000");
        //Finding and clicking on save button
        baseClass.findElementOnPage(chromeDriver, "SaveButton", FindBy.Id).Click();


    }

    public void checkEditTimeAndMaterial(IWebDriver chromeDriver)
    {
        bool updated=false;
        //Getting all the rows from the data table on the first page
        ReadOnlyCollection<IWebElement> rows = baseClass.findElementsOnPage(chromeDriver, "//tr[@role='row']", FindBy.XPath);
        for (int i = 0; i < rows.Count; i++)
        {
            //Checking all the rows for column 0(name) to verify if the record has been updated successfully
            if (rows[i].FindElements(By.TagName("td"))[0].Text == "Edited Successfully")
            {
                updated=true;

            }
        }
        Assert.That(updated, Is.True,"Record has not been updated");
    }
}
