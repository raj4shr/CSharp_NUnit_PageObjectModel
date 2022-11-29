using TechTalk.SpecFlow;
using Login_Test_Automation_TurnUp;
using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;

namespace Login_Test_Automation_TurnUp.StepDefinitions
{
    [Binding]
    public class CreateNewTimeandMaterialStepDefinitions : WebDriver
    {
        NewTimeAndMaterial? NTAM;

        [When(@"I navigate to the time and material page")]
        public void WhenINavigateToTheTimeAndMaterialPage()
        {
            TimeAndMaterial TAM = new();
            TAM.gotoTimeAndMaterial(chromeDriver);
        }

        
  
        [When(@"I have created a new time and material record")]
        public void WhenIHaveCreatedANewTimeAndMaterialRecord()
        {
            NTAM = new();
            NTAM.createNewTandM(chromeDriver);
        }

        [Then(@"A new time and material should be created sucessfully")]
        public void ThenANewTimeAndMaterialShouldBeCreatedSucessfully()
        {
            NTAM.checkNewTimeAndMaterialCreated(chromeDriver);
            chromeDriver.Quit();
        }


    }
}