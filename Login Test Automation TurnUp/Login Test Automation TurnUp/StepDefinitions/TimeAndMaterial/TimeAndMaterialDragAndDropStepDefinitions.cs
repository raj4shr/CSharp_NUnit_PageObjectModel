using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;

namespace Login_Test_Automation_TurnUp.StepDefinitions.TimeAndMaterial
{
    [Binding]
    public class TimeAndMaterialDragAndDropStepDefinitions : WebDriver
    {
        DragAndDrop TMDAD;
        WebDriver? wd;

        public TimeAndMaterialDragAndDropStepDefinitions(ScenarioContext scenarioContext)
        {
            wd = (WebDriver)scenarioContext["driver"];
        }

        [When(@"I have dragged and dropped a column tab in time and material page")]
        public void WhenIHaveDraggedAndDroppedAColumnTabInTimeAndMaterialPage()
        {
            TMDAD = new();
            TMDAD.dragAnddrop(wd.chromeDriver);
            //throw new PendingStepException();
        }

        [Then(@"The time and material page should be sorted successfully")]
        public void ThenTheTimeAndMaterialPageShouldBeSortedSuccessfully()
        {
            TMDAD.dragAnddropCloseBDD(wd.chromeDriver);
            Console.WriteLine("Time and material drag and drop tab closed successfully.....");
            wd.chromeDriver.Quit();
            //throw new PendingStepException();
        }

    }
}
