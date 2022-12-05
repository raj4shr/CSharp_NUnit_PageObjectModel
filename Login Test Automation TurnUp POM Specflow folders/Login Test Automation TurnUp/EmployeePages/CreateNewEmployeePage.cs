namespace Login_Test_Automation_TurnUp.EmployeeFolder;

public class CreateNewEmployeePage : findByLocator
{
    private string name = "";

    private turnUpPortalBaseClass baseClass;

    public CreateNewEmployeePage()
    {
        baseClass = new();
    }

    public void CreateNewEmployee(IWebDriver chromeDriver)
    {
        //Generating a random name
        name = baseClass.firstNameRand()+baseClass.middleNameRand();
        string contact = "";
        //Finding and clicking the create new button
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Create')]", FindBy.XPath).Click();
        //Finding and inputting the name value
        baseClass.findElementOnPage(chromeDriver, "Name", FindBy.Id).SendKeys(name);
        //Finding and inputting the username value
        baseClass.findElementOnPage(chromeDriver, "Username", FindBy.Id).SendKeys(name + "2022");
        //Finding and clicking the edit contact button button
        baseClass.findElementOnPage(chromeDriver, "EditContactButton", FindBy.Id).Click();
        //Finding the edit contact iframe and switching to it
        IWebElement editFrame = baseClass.findElementOnPage(chromeDriver, "//iframe[@title='Edit Contact']",FindBy.XPath);
        chromeDriver.SwitchTo().Frame(editFrame);
        //Finding the elements in the edit contact iframe and inputtiong the values
        IWebElement firstName = baseClass.findElementOnPage(chromeDriver, "FirstName", FindBy.Id);
        firstName.SendKeys(name);
        contact = contact + firstName.Text;
        IWebElement lastName = baseClass.findElementOnPage(chromeDriver, "LastName", FindBy.Id);
        lastName.SendKeys(baseClass.lastNameRand());
        contact = contact + "  " + lastName.Text;
        IWebElement phone = baseClass.findElementOnPage(chromeDriver, "Phone", FindBy.Id);
        phone.SendKeys(baseClass.phoneRand());
        contact = contact + "  " + phone.Text;
        IWebElement email=baseClass.findElementOnPage(chromeDriver,"email",FindBy.Id);
        email.SendKeys(baseClass.emailRand(name));
        contact=contact + "  " + email.Text;
        //Finding and cliking the save button on the iframe
        baseClass.findElementOnPage(chromeDriver, "submitButton", FindBy.Id).Click();
        //Changing back to the default content
        chromeDriver.SwitchTo().DefaultContent();
        //Finding the rest of the elements on the create contact page and inputting values
        baseClass.findElementOnPage(chromeDriver, "ContactDisplay", FindBy.Id).SendKeys(contact);
        baseClass.findElementOnPage(chromeDriver, "Password", FindBy.Id).SendKeys("123asdA#");
        baseClass.findElementOnPage(chromeDriver, "RetypePassword", FindBy.Id).SendKeys("123asdA#");
        //Finding and clicking the save button and clicking the back to list hyperlink
        baseClass.findElementOnPage(chromeDriver, "SaveButton", FindBy.Id).Click();
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Back to List')]", FindBy.XPath).Click();
        Thread.Sleep(3000);
    }

    public void CheckCreatedEmployee(IWebDriver chromeDriver)
    {
        bool created = false;
        //Finding the goto last page button and clicking it
        baseClass.findElementOnPage(chromeDriver, "//span[contains(text(),'Go to the last page')]", FindBy.XPath).Click();
        //Getting all the rows from the data table
        ReadOnlyCollection<IWebElement> rows = baseClass.findElementsOnPage(chromeDriver, "//tr[@role='row']", FindBy.XPath);
        ReadOnlyCollection<IWebElement>? cols;
        //Checking column 0(contact name) from each row to verify a contact has been created
        for(int i=0;i<rows.Count;i++)
        {
            cols = rows[i].FindElements(By.TagName("td"));
            if (cols[0].Text == name)
            {
                created=true;
            }
        }
        Assert.That(created, Is.True, "New time and material record not created");
    }
}


