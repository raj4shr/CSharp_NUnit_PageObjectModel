using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;

namespace Login_Test_Automation_TurnUp.StepDefinitions.TimeAndMaterial
{
    [Binding]
    public class DeleteTimeAndMaterialStepDefinitions : WebDriver
    {
        DeleteTimeAndMaterial? DTAM;
        WebDriver? wd;

        public DeleteTimeAndMaterialStepDefinitions(ScenarioContext scenarioContext)
        {
            wd = (WebDriver)scenarioContext["driver"];
        }

        [When(@"I have deleted an time and material record")]
        public void WhenIHaveDeletedAnTimeAndMaterialRecord()
        {
            DTAM = new();
            DTAM.deleteTAM(wd.chromeDriver);
        }

        [Then(@"Time and material record should be deleted successfully")]
        public void ThenTimeAndMaterialRecordShouldBeDeletedSuccessfully()
        {
            Console.WriteLine("Time and material record has been deleted successfully.....");
            wd.chromeDriver.Quit();
            // throw new PendingStepException();
        }


    }
}
