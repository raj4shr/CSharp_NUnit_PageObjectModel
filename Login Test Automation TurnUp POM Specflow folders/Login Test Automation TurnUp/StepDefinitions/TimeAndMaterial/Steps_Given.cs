using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;


namespace Login_Test_Automation_TurnUp.StepDefinitions.TimeAndMaterial
{
   
    [Binding]
    public partial class TimeAndMaterial_StepDefinitions : WebDriver
    {
        EditTandM? ETAM;
        NewTimeAndMaterial? NTAM;
        DeleteTimeAndMaterial? DTAM;
        DragAndDrop TMDAD;
        WebDriver? wd;

        [Given(@"I logged into turnup portal TAM successfully")]
        public void GivenILoggedIntoTurnupPortalTAMSuccessfully()
        {
            wd= new WebDriver();
            wd.login();
        }


    }
}
