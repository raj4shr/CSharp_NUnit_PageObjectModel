

using OpenQA.Selenium.Chrome;

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
        //turnUpPortalBaseClass baseClass = new();
        name = baseClass.firstNameRand()+baseClass.middleNameRand();
        string contact = "";
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Create')]", FindBy.XPath).Click();
        baseClass.findElementOnPage(chromeDriver, "Name", FindBy.Id).SendKeys(name);
        baseClass.findElementOnPage(chromeDriver, "Username", FindBy.Id).SendKeys(name + "2022");
        baseClass.findElementOnPage(chromeDriver, "EditContactButton", FindBy.Id).Click();
        chromeDriver.SwitchTo().Frame(baseClass.findElementOnPage(chromeDriver, "//iframe[@title='Edit Contact']", FindBy.XPath));
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
        baseClass.findElementOnPage(chromeDriver, "submitButton", FindBy.Id).Click();
        chromeDriver.SwitchTo().DefaultContent();
        baseClass.findElementOnPage(chromeDriver, "ContactDisplay", FindBy.Id).SendKeys(contact);
        baseClass.findElementOnPage(chromeDriver, "Password", FindBy.Id).SendKeys("123asdA#");
        baseClass.findElementOnPage(chromeDriver, "RetypePassword", FindBy.Id).SendKeys("123asdA#");
        baseClass.findElementOnPage(chromeDriver, "SaveButton", FindBy.Id).Click();
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Back to List')]", FindBy.XPath).Click();
        Thread.Sleep(3000);
        //baseClass.findElementOnPage(chromeDriver, "//span[contains(text(),'Go to the last page')]", FindBy.XPath).Click();
        Thread.Sleep(3000);
    }

    public void CheckCreatedEmployee(IWebDriver chromeDriver)
    {
        baseClass.findElementOnPage(chromeDriver, "//span[contains(text(),'Go to the last page')]", FindBy.XPath).Click();
        ReadOnlyCollection<IWebElement> rows = baseClass.findElementsOnPage(chromeDriver, "//tr[@role='row']", FindBy.XPath);
        for(int i=0;i<rows.Count;i++)
        {
            Console.WriteLine(rows[i].FindElements(By.TagName("td"))[0].Text);
            if (rows[i].FindElements(By.TagName("td"))[0].Text == name)
            {
                Assert.That(rows[i].FindElements(By.TagName("td"))[0].Text == name);
                //Console.WriteLine("Record created");
            }
        }

    }
}


