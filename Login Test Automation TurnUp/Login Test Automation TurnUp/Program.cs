using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;


//open web browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
//driver.Manage().Window.FullScreen();

//launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
//driver.Manage().Window.FullScreen();
//driver.Manage().Window.Maximize();

//identify username element and send data
IWebElement loginUsername = driver.FindElement(By.Id("UserName"));
loginUsername.SendKeys("hari");

//identify password element and send data
IWebElement loginPassword = driver.FindElement(By.Id("Password"));
loginPassword.SendKeys("123123");


//.identify login button and click login to enter main page
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\'loginForm\']/form/div[3]/input[1]"));
loginButton.Click();
//driver.Manage().Window.Maximize();

//identifying an element in the login home page to confirm if our test passed
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\'logoutForm\']/ul/li/a"));

if (helloHari.Displayed == true)
    Console.WriteLine("Test Passed");
else
    Console.WriteLine("Test Failed");

//Identifying Administration menu item and clicking
//IWebElement administrationMenuItem = driver.FindElement(By.LinkText("Administration"));//by link text
IWebElement administrationMenuItem = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));//by full xpath
administrationMenuItem.Click();

//Identifying time and material menu item and clicking

//IWebElement timeAndMaterial = driver.FindElement(By.LinkText("Time & Materials")); //by link text
//IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));//by full xpath
IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeAndMaterial.Click();

//to click and sort the Code tab in time and material pagfe
//IWebElement codeTab = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/div/table/thead/tr/th[1]/a"));
//codeTab.Click();

//to click and sort using the typecode in time and material page
IWebElement typeCode = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/div/table/thead/tr/th[2]/a"));
//Thread.Sleep(5000);
typeCode.Click();

IWebElement tableGrid = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table"));
Console.WriteLine("just checking");

Console.WriteLine(driver.FindElements(By.XPath("/html/body/div[4]/div/div/div[3]/table")));