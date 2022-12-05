using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;

namespace Login_Test_Automation_TurnUp.StepDefinitions.TimeAndMaterial
{
    [Binding]
    public class EditTimeAndMaterialStepDefinitions : WebDriver
    {
        EditTandM? ETAM;
        WebDriver? wd;
        public EditTimeAndMaterialStepDefinitions(ScenarioContext scenarioContext)
        {
            wd = (WebDriver)scenarioContext["driver"];
        }

        [When(@"I have edited a time and material record")]
        public void WhenIHaveEditedATimeAndMaterialRecord()
        {
            ETAM = new();
            ETAM.editTimeAndMaterial(wd.chromeDriver);
        }

        [Then(@"time and material record should be edited successfully")]
        public void ThenTimeAndMaterialRecordShouldBeEditedSuccessfully()
        {
            ETAM.checkEditTimeAndMaterial(wd.chromeDriver);
            wd.chromeDriver.Quit();
        }


    }
}
