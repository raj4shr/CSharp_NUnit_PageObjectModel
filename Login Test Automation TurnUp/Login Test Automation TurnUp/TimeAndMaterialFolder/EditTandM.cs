

namespace Login_Test_Automation_TurnUp.Pages;

public class EditTandM : findByLocator
{
    turnUpPortalBaseClass? baseClass;
    public void editTimeAndMaterial(IWebDriver chromeDriver)
    {
        //Thread.Sleep(5000);
        baseClass = new();
        Thread.Sleep(5000);
        baseClass.findElementsOnPage(chromeDriver, "//a[@class='k-button k-button-icontext k-grid-Edit'][contains(text(),'Edit')]", FindBy.XPath)[1].Click();
        baseClass.findElementOnPage(chromeDriver, "//span[@class='k-widget k-dropdown k-header text-box single-line'][@role='listbox']", FindBy.XPath).Click();
        baseClass.findElementOnPage(chromeDriver, "//li[@role='option'][contains(text(),'Material')]", FindBy.XPath).Click();
        baseClass.findElementOnPage(chromeDriver, "Code", FindBy.Id).Clear();
        baseClass.findElementOnPage(chromeDriver, "Code", FindBy.Id).SendKeys("Edited Successfully");
        baseClass.findElementOnPage(chromeDriver, "Description", FindBy.Id).Clear();
        baseClass.findElementOnPage(chromeDriver, "Description", FindBy.Id).SendKeys("This row has been edited using selenium code");
        IWebElement element1= baseClass.findElementOnPage(chromeDriver, "//input[@type='text'][@class='k-formatted-value k-input']", FindBy.XPath);//clicking on overlapping element
        element1.Click();
        IWebElement element2= baseClass.findElementOnPage(chromeDriver, "Price", FindBy.Id);
        element2.Clear();
        //Thread.Sleep(1000);
        element1.Click();
        Thread.Sleep(1000);
        element2.SendKeys("1000");
        baseClass.findElementOnPage(chromeDriver, "SaveButton", FindBy.Id).Click();


    }

    public void checkEditTimeAndMaterial(IWebDriver chromeDriver)
    {
        ReadOnlyCollection<IWebElement> rows = baseClass.findElementsOnPage(chromeDriver, "//tr[@role='row']", FindBy.XPath);
        for (int i = 0; i < rows.Count; i++)
        {
            if (rows[i].FindElements(By.TagName("td"))[0].Text == "Edited Successfully")
            {
                Console.WriteLine("Time and material record has been edited.....");
                //Assert.Pass();
            }
        }
    }
}
