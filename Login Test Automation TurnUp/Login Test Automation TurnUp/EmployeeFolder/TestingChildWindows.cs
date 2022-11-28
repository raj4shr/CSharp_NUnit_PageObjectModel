

namespace Login_Test_Automation_TurnUp.EmployeeFolder;

public class TestingChildWindows : findByLocator
{
    public void HandleChildWindow(IWebDriver chromeDriver)
    {
        turnUpPortalBaseClass baseClass = new();
        string contact = "";
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Create')]", FindBy.XPath).Click();
        baseClass.findElementOnPage(chromeDriver, "Name", FindBy.Id).SendKeys("Kratoss");
        baseClass.findElementOnPage(chromeDriver, "Username", FindBy.Id).SendKeys("Kratos22Nov");
        baseClass.findElementOnPage(chromeDriver, "EditContactButton", FindBy.Id).Click();
        chromeDriver.SwitchTo().Frame(baseClass.findElementOnPage(chromeDriver, "//iframe[@title='Edit Contact']", FindBy.XPath));
        IWebElement firstName= baseClass.findElementOnPage(chromeDriver, "FirstName", FindBy.Id);
        firstName.SendKeys("KratosRagnorokGOW");
        contact = contact + firstName.Text;
        IWebElement lastName = baseClass.findElementOnPage(chromeDriver, "LastName", FindBy.Id);
        lastName.SendKeys("GodOfWar");
        contact= contact + "  " + lastName.Text;
        IWebElement phone= baseClass.findElementOnPage(chromeDriver, "Phone", FindBy.Id);
        phone.SendKeys("021021021");
        contact=contact + "  " + phone.Text;
        baseClass.findElementOnPage(chromeDriver, "submitButton", FindBy.Id).Click();
        chromeDriver.SwitchTo().DefaultContent();
        baseClass.findElementOnPage(chromeDriver, "ContactDisplay", FindBy.Id).SendKeys(contact);
        baseClass.findElementOnPage(chromeDriver, "Password", FindBy.Id).SendKeys("123asdA#");
        baseClass.findElementOnPage(chromeDriver, "RetypePassword", FindBy.Id).SendKeys("123asdA#");
        Thread.Sleep(2000);
        baseClass.findElementOnPage(chromeDriver, "SaveButton", FindBy.Id).Click();
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Back to List')]", FindBy.XPath).Click();
        Thread.Sleep(3000);
        baseClass.findElementOnPage(chromeDriver, "//span[contains(text(),'Go to the last page')]", FindBy.XPath).Click();
        
    }

}
