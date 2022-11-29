using Login_Test_Automation_TurnUp;
using TechTalk.SpecFlow;
using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;

namespace Login_Test_Automation_TurnUp.StepDefinitions
{
    [Binding]
    public class EditTimeAndMaterialStepDefinitions : WebDriver
    {
        EditTandM? ETAM;
        [When(@"I have edited a time and material record")]
        public void WhenIHaveEditedATimeAndMaterialRecord()
        {
            ETAM = new();
            ETAM.editTimeAndMaterial(chromeDriver);
        }

        [Then(@"time and material record should be edited successfully")]
        public void ThenTimeAndMaterialRecordShouldBeEditedSuccessfully()
        {
            ETAM.checkEditTimeAndMaterial(chromeDriver);
            chromeDriver.Quit();
        }


    }
}
