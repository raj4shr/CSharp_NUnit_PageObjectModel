using Login_Test_Automation_TurnUp;
using TechTalk.SpecFlow;
using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;

namespace Login_Test_Automation_TurnUp.StepDefinitions
{
    [Binding]
    public class DeleteTimeAndMaterialStepDefinitions : WebDriver
    {
        DeleteTimeAndMaterial? DTAM;

        [When(@"I have deleted an time and material record")]
        public void WhenIHaveDeletedAnTimeAndMaterialRecord()
        {
            DTAM = new();
            DTAM.deleteTAM(chromeDriver);
        }

        [Then(@"Time and material record should be deleted successfully")]
        public void ThenTimeAndMaterialRecordShouldBeDeletedSuccessfully()
        {
            Console.WriteLine("Time and material record has been deleted successfully.....");
            chromeDriver.Quit();
           // throw new PendingStepException();
        }


    }
}
