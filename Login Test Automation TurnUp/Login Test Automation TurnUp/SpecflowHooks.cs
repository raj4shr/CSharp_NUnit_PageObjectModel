using TechTalk.SpecFlow.Infrastructure;

namespace Login_Test_Automation_TurnUp
{
    [Binding]
    public sealed class SpecflowHooks
    {
        private  readonly ISpecFlowOutputHelper _outputHelper;
        
        //Injection of specflow output API
        public SpecflowHooks(ISpecFlowOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
           Debug.WriteLine("Before Test Run");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Debug.WriteLine("After Test Run");
        }

        [BeforeFeature]
        public static void BeforeTestFeature(FeatureContext fContext)
        {
            Debug.WriteLine("Before Test Feature");
            Debug.WriteLine(fContext.FeatureInfo.Title);
            Debug.WriteLine(fContext.FeatureInfo.Description);
        }

        [AfterFeature]
        public static void AfterTestFeature()
        {
            Debug.WriteLine("After Test Feature");
        }

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext sContext)
        {
            _outputHelper.WriteLine("Before Test Scenario");
            _outputHelper.WriteLine(sContext.ScenarioInfo.Title);
            _outputHelper.WriteLine(sContext.ScenarioInfo.Description);
        }
        
        [AfterScenario]
        public void AfterScenario()
        {
            Debug.WriteLine("After Test Scenario");
        }

        [BeforeStep]
        public void BeforeStep()
        {

            Debug.WriteLine("Before Test Step");
        }
        [AfterStep]
        public void AfterStep()
        {
            Debug.WriteLine(nameof(AfterStep));//Gives the name of the method
        }


    }
}
