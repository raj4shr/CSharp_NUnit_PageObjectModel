

namespace Login_Test_Automation_TurnUp.SetupCommonClassFolder;
[Parallelizable]
public class WebDriver
{
  
    public IWebDriver? chromeDriver { get; set; }

    [SetUp]
    public void login()
    {
        chromeDriver = new ChromeDriver();
        PortalLogin pLogin = new(chromeDriver);
    }
    [TearDown]
    public void CloseTestAutomation()
    {
        chromeDriver.Quit();
    }
}
