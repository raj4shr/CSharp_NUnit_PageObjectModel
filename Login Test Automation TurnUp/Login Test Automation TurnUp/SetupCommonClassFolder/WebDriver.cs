

namespace Login_Test_Automation_TurnUp.SetupCommonClassFolder;
public class WebDriver
{
    public static IWebDriver? chromeDriver;
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
