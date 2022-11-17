using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;


//open web browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
//driver.Manage().Window.FullScreen();

//launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

Thread.Sleep(2000);

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
Thread.Sleep(5000);

//finding numbers of rows and columns in a table
IWebElement webTable = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody"));
ReadOnlyCollection<IWebElement> rows = webTable.FindElements(By.TagName("tr"));
webTable = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr"));
ReadOnlyCollection<IWebElement> cols = webTable.FindElements(By.TagName("td"));
try
{
    for (int i = 1; i <= rows.Count(); i++)
    {
        IWebElement disp = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));
        Console.WriteLine(disp.Text);
        for (int j = 1; j <= 4; j++)
        {
            //Thread.Sleep(2000);
            //string str = "//*[@id=\\\"tmsGrid\\\"]/div[3]/table/tbody/tr[" + i + "]/td[" + j + "]";
            IWebElement columns = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[" + j + "]"));
            Console.Write("     " + columns.Text + "     ");
        }

    }
}
catch
{
    Console.WriteLine("catch exception");
}

//clicking page number 2
IWebElement nextPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/ul/li[2]/a"));
nextPage.Click();
//driver.SwitchTo().Alert().Accept();

//clicking the items per page drop down box
IWebElement itemsPerPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/span[1]/span/span/span[2]/span"));
itemsPerPage.Click();

//selecting 20 items per page from the drop down box
IWebElement selectItemsPerPage = driver.FindElement(By.XPath("/html/body/div[5]/div/ul/li[3]"));
selectItemsPerPage.Click();

//dragging a column header and droping in the tab to group by columns
IWebElement dragHeaderElement = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[2]/div/table/thead/tr/th[1]/a"));
//dragHeaderGroupBy.
IWebElement dropIntoElement = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[1]"));

//selenium actions class object created for drag and drop operation
Actions builder = new Actions(driver);

builder.DragAndDrop(dragHeaderElement, dropIntoElement).Perform();

Thread.Sleep(5000);

//closing the drag and drop column using full xpath(normal xpath won't work)
IWebElement closeDragAndDropColumn = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[1]/div/a[2]/span"));
closeDragAndDropColumn.Click();

//logging off from the portal
helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
helloHari.Click();
IWebElement logOff = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/ul/li[2]/a"));
logOff.Click();

Thread.Sleep(2000);
//closing the chrome browser
driver.Close();



