using System.Threading.Tasks;
using static Login_Test_Automation_TurnUp.findByLocator;

namespace Login_Test_Automation_TurnUp.EmployeeFolder;

public class EditEmployeePage
{
    public void editEmployee(IWebDriver chromeDriver)
    {
        //Thread.Sleep(5000);
        turnUpPortalBaseClass baseClass = new();
        Thread.Sleep(5000);
        baseClass.findElementsOnPage(chromeDriver, "//a[@class='k-button k-button-icontext k-grid-Edit'][contains(text(),'Edit')]", FindBy.XPath)[0].Click();
        IWebElement element= baseClass.findElementOnPage(chromeDriver, "Name", FindBy.Id);
        element.Clear();
        element.SendKeys("Atreus");
        baseClass.findElementOnPage(chromeDriver, "SaveButton", FindBy.Id).Click();
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Back to List')]", FindBy.XPath).Click();
        ReadOnlyCollection<IWebElement> rows = baseClass.findElementsOnPage(chromeDriver, "//tr[@role='row']", FindBy.XPath);
        for (int i = 0; i < rows.Count; i++)
        {
            if (rows[i].FindElements(By.TagName("td"))[0].Text == "Atreus")
            {
                Console.WriteLine("Time and material record has been edited");
                //Assert.Pass();
            }
        }
    }
}
