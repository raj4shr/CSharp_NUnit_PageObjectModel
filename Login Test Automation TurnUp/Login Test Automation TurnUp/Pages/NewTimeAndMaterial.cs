using NUnit.Framework;
using OpenQA.Selenium;

using System.Collections.ObjectModel;


namespace Login_Test_Automation_TurnUp.Pages;

public class NewTimeAndMaterial : findByLocator
{
    public void createNewTandM(IWebDriver chromeDriver)
    {
        turnUpPortalBaseClass baseClass = new();
        baseClass.findElementOnPage(chromeDriver, "//a[contains(text(),'Create New')]", FindBy.XPath).Click();
        string str = "Code0";
        baseClass.findElementOnPage(chromeDriver, "Code", FindBy.Id).SendKeys(str);
        baseClass.findElementOnPage(chromeDriver, "Description", FindBy.Id).SendKeys("This record is new");
        baseClass.findElementOnPage(chromeDriver, "//input[@class='k-formatted-value k-input']", FindBy.XPath).SendKeys("100");
        baseClass.findElementOnPage(chromeDriver, "SaveButton", FindBy.Id).Click();
        baseClass.findElementOnPage(chromeDriver, "//a[@title='Go to the last page'][@class='k-link k-pager-nav k-pager-last']", FindBy.XPath).Click();
        ReadOnlyCollection<IWebElement> rows = baseClass.findElementsOnPage(chromeDriver, "//tr[@role='row']", FindBy.XPath);
        Assert.That(rows[rows.Count - 1].FindElements(By.TagName("td"))[0].Text == str,"New record has been created");
    }
}
