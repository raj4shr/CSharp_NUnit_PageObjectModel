using TechTalk.SpecFlow;
using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;


namespace Login_Test_Automation_TurnUp.StepDefinitions.TimeAndMaterial
{
    
    [Binding]
    public class CreateNewTimeandMaterialStepDefinitions : WebDriver
    {
        NewTimeAndMaterial? NTAM;
        WebDriver? wd;
        ScenarioContext? _scenarioContext;

        public CreateNewTimeandMaterialStepDefinitions(ScenarioContext scenarioContext )
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I logged into turnup portal TAM successfully")]
        public void GivenILoggedIntoTurnupPortalTAMSuccessfully()
        {
           
            wd = new();
           _scenarioContext.Add("driver",wd);
            wd.login();
        }

        [When(@"I navigate to the time and material page")]
        public void WhenINavigateToTheTimeAndMaterialPage()
        { 
            Login_Test_Automation_TurnUp.Pages.TimeAndMaterial TAM = new();
            TAM.gotoTimeAndMaterial(wd.chromeDriver);
        }



        [When(@"I have created a new time and material record")]
        public void WhenIHaveCreatedANewTimeAndMaterialRecord()
        {
            NTAM = new();
            NTAM.createNewTandM(wd.chromeDriver);
        }

        [Then(@"A new time and material should be created sucessfully")]
        public void ThenANewTimeAndMaterialShouldBeCreatedSucessfully()
        {
            NTAM.checkNewTimeAndMaterialCreated(wd.chromeDriver);
            wd.chromeDriver.Quit();
        }


    }
}
