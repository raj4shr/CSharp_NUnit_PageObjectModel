using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.ObjectModel;


namespace Login_Test_Automation_TurnUp.Pages;

public class EditTandM : findByLocator
{
    public void editTimeAndMaterial(IWebDriver chromeDriver)
    {
        turnUpPortalBaseClass baseClass = new();
        baseClass.findElementsOnPage(chromeDriver, "//a[@class='k-button k-button-icontext k-grid-Edit'][contains(text(),'Edit')]", FindBy.XPath)[3].Click();
        baseClass.findElementOnPage(chromeDriver, "//span[@class='k-widget k-dropdown k-header text-box single-line'][@role='listbox']", FindBy.XPath).Click();
        baseClass.findElementOnPage(chromeDriver, "//li[@role='option'][contains(text(),'Material')]", FindBy.XPath).Click();
        baseClass.findElementOnPage(chromeDriver, "Code", FindBy.Id).Clear();
        baseClass.findElementOnPage(chromeDriver, "Code", FindBy.Id).SendKeys("1234554321");
        baseClass.findElementOnPage(chromeDriver, "Description", FindBy.Id).Clear();
        baseClass.findElementOnPage(chromeDriver, "Description", FindBy.Id).SendKeys("This row has been edited using selenium code");
        baseClass.findElementOnPage(chromeDriver, "//input[@type='text'][@class='k-formatted-value k-input']", FindBy.XPath).Click();//clicking on overlapping element
        
        baseClass.findElementOnPage(chromeDriver, "Price", FindBy.Id).SendKeys("1234");
        baseClass.findElementOnPage(chromeDriver, "SaveButton", FindBy.Id).Click();

        ReadOnlyCollection<IWebElement> rows = baseClass.findElementsOnPage(chromeDriver, "//tr[@role='row']", FindBy.XPath);
        for (int i = 0; i < rows.Count; i++)
        {
            if (rows[i].FindElements(By.TagName("td"))[0].Text == "1234554321")
            { 
                //Console.WriteLine("Time and material record has been edited");
                Assert.Pass();
            }
        }
    }
}
