

namespace Login_Test_Automation_TurnUp.SetupCommonClassFolder;
public class WebDriver
{


    public IWebDriver? chromeDriver { get; set; }
    
    public void login()
    {
        chromeDriver = new ChromeDriver();
        PortalLogin pLogin = new(chromeDriver);
    }
}
