namespace Login_Test_Automation_TurnUp.Pages;

public class DeleteTimeAndMaterial : findByLocator
{
    public void deleteTAM(IWebDriver chromeDriver)
    {
        Thread.Sleep(2000);
        turnUpPortalBaseClass baseClass = new();
        //Finding and clicking on the delete button from row 5 of the data table
        baseClass.findElementsOnPage(chromeDriver,"//a[@class='k-button k-button-icontext k-grid-Delete']", FindBy.XPath)[4].Click();
        Thread.Sleep(2000);
        //Accepting the ok from the delete dialog box
        chromeDriver.SwitchTo().Alert().Accept();
    }
}
