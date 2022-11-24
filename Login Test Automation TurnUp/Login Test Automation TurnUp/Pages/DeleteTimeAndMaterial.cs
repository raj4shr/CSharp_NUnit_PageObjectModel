

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Login_Test_Automation_TurnUp.Pages;

public class DeleteTimeAndMaterial : findByLocator
{
    public void deleteTAM(IWebDriver chromeDriver)
    {
        Thread.Sleep(2000);
        turnUpPortalBaseClass baseClass = new();
        baseClass.findElementsOnPage(chromeDriver,"//a[@class='k-button k-button-icontext k-grid-Delete']", FindBy.XPath)[4].Click();
        Console.WriteLine("this is a test");
        chromeDriver.SwitchTo().Alert().Accept();
        Assert.Pass();
    }
}
