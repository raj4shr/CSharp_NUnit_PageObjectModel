using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Test_Automation_TurnUp.StepDefinitions.TimeAndMaterial
{
    public partial class TimeAndMaterial_StepDefinitions
    {

        [When(@"I navigate to the time and material page")]
        public void WhenINavigateToTheTimeAndMaterialPage()
        {
            Login_Test_Automation_TurnUp.Pages.TimeAndMaterial TAM = new();
            TAM.gotoTimeAndMaterial(chromeDriver);
        }

        [When(@"I have created a new time and material record")]
        public void WhenIHaveCreatedANewTimeAndMaterialRecord()
        {
            NTAM = new();
            NTAM.createNewTandM(chromeDriver);
        }

        [When(@"I have deleted an time and material record")]
        public void WhenIHaveDeletedAnTimeAndMaterialRecord()
        {
            DTAM = new();
            DTAM.deleteTAM(chromeDriver);
        }

        [When(@"I have edited a time and material record")]
        public void WhenIHaveEditedATimeAndMaterialRecord()
        {
            ETAM = new();
            ETAM.editTimeAndMaterial(chromeDriver);
        }

        [When(@"I have dragged and dropped a column tab in time and material page")]
        public void WhenIHaveDraggedAndDroppedAColumnTabInTimeAndMaterialPage()
        {
            TMDAD = new();
            TMDAD.dragAnddrop(chromeDriver);
            //throw new PendingStepException();
        }
    }
}
