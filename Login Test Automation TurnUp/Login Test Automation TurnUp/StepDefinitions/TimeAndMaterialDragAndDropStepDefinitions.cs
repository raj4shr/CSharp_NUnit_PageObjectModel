
using TechTalk.SpecFlow;
using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;

namespace Login_Test_Automation_TurnUp.StepDefinitions
{
    [Binding]
    public class TimeAndMaterialDragAndDropStepDefinitions : WebDriver
    {
        DragAndDrop TMDAD;
        [When(@"I have dragged and dropped a column tab in time and material page")]
        public void WhenIHaveDraggedAndDroppedAColumnTabInTimeAndMaterialPage()
        {
            TMDAD = new();
            TMDAD.dragAnddrop(chromeDriver);
            //throw new PendingStepException();
        }

        [Then(@"The time and material page should be sorted successfully")]
        public void ThenTheTimeAndMaterialPageShouldBeSortedSuccessfully()
        {
            TMDAD.dragAnddropCloseBDD(chromeDriver);
            Console.WriteLine("Time and material drag and drop tab closed successfully.....");
            chromeDriver.Quit();
            //throw new PendingStepException();
        }

    }
}
