using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


//open web browser
IWebDriver driver = new ChromeDriver();

//launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//identify username element and send data
IWebElement loginUsername = driver.FindElement(By.Id("UserName"));
loginUsername.SendKeys("hari");

//identify password element and send data
IWebElement loginPassword = driver.FindElement(By.Id("Password"));
loginPassword.SendKeys("123123");


//.identify login button and click login to enter main page
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\'loginForm\']/form/div[3]/input[1]"));
loginButton.Click();
driver.Manage().Window.Maximize();

//identifying an element in the login home page to confirm if our test passed
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\'logoutForm\']/ul/li/a"));

if (helloHari.Displayed == true)
    Console.WriteLine("Test Passed");
else
    Console.WriteLine("Test Failed");

//Identifying Administration menu item and clicking
IWebElement administrationMenuItem = driver.FindElement(By.LinkText("Administration"));
administrationMenuItem.Click();

//Identifying time and material menu item and clicking

IWebElement timeAndMaterial = driver.FindElement(By.LinkText("Time & Materials"));
timeAndMaterial.Click();
