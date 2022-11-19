using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

IWebElement getTableRowsAfterEdit;
ReadOnlyCollection<IWebElement> getRowsAfterEditCols;
//ReadOnlyCollection<IWebElement> getColsAfterEdit;
string str;
WebDriverWait waitForElement; //to be used for explicit waits

//open web browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
//driver.Manage().Window.FullScreen();

//launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

//identify username element and send data
IWebElement loginUsername = driver.FindElement(By.Id("UserName"));
loginUsername.SendKeys("hari");

//identify password element and send data
IWebElement loginPassword = driver.FindElement(By.Id("Password"));
loginPassword.SendKeys("123123");

/*Actions enterButtonPressed = new Actions(driver);
enterButtonPressed.SendKeys(Keys.Enter);*/

//.identify login button and click login to enter main page
IWebElement loginButton = driver.FindElement(By.XPath("//input[contains(@value,'Log in')]"));
loginButton.Click();
//driver.Manage().Window.Maximize();*/
//identifying an element in the login home page to confirm if our test passed
IWebElement helloHari = driver.FindElement(By.XPath("//a[contains(text(),\"Hello hari!\")]"));

//Identifying Administration menu item and clicking
IWebElement administrationMenuItem = driver.FindElement(By.XPath("//a[contains(text(),'Administration')]"));
administrationMenuItem.Click();

//Identifying time and material menu item and clicking
IWebElement timeAndMaterial = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));
timeAndMaterial.Click();

//Creating a new time and materials node
IWebElement createNewTimeAndMaterialNode = driver.FindElement(By.XPath("//a[contains(text(),'Create New')]"));
createNewTimeAndMaterialNode.Click();
IWebElement inputNewCode = driver.FindElement(By.Id("Code"));
inputNewCode.SendKeys("This is to test");
IWebElement inputDescription = driver.FindElement(By.Id("Description"));
inputDescription.SendKeys("This is a new record");
str = inputDescription.Text;
IWebElement inputPrice = driver.FindElement(By.XPath("//input[@class='k-formatted-value k-input']"));
//inputPrice.Click();//Because of getting 'element not interactable' error
inputPrice.SendKeys("100");
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();

//navigating to the last page and confirming a new record is created
IWebElement gotoLastPage = driver.FindElement(By.XPath("//span[contains(text(),'Go to the last page')]"));
gotoLastPage.Click();

checkTestPassed(str);

//to click and sort using the typecode in time and material page
IWebElement typeCode = driver.FindElement(By.XPath("//a[contains(text(),'TypeCode')]"));
typeCode.Click();

//clicking page number 2
IWebElement nextPage = driver.FindElement(By.XPath("//a[contains(text(),'2')]"));
nextPage.Click();

//clicking the items per page drop down box
IWebElement itemsPerPage = driver.FindElement(By.XPath("//span[contains(text(),'select')]"));
itemsPerPage.Click();

//selecting 20 items per page from the drop down box
IWebElement selectItemsPerPage = driver.FindElement(By.XPath("//li[contains(text(),'20')]"));
selectItemsPerPage.Click();

//dragging a column header and droping in the tab to group by columns
IWebElement dragHeaderElement = driver.FindElement(By.XPath("//th[@data-field='Code']"));
IWebElement dropIntoElement = driver.FindElement(By.XPath("//div[contains(text(),'Drag a column header and drop it here to group by that column')]"));

//selenium actions class object created for drag and drop operation
Actions builder = new Actions(driver);
builder.DragAndDrop(dragHeaderElement, dropIntoElement).Perform();

//closing the drag and drop column
IWebElement closeDragAndDropColumn = driver.FindElement(By.XPath("//span[@class='k-icon k-group-delete']"));
closeDragAndDropColumn.Click();

//Testing edit button
ReadOnlyCollection<IWebElement> editButton = driver.FindElements(By.XPath("//a[contains(text(),'Edit')]"));
editButton[4].Click();//editing the 5th record
IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
codeTextBox.Clear();
codeTextBox.SendKeys("This is edited");
str = codeTextBox.Text;
IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
editSaveButton.Click();

//confirm if the edit has been saved
checkTestPassed(str);

//Deleting the 1st record
ReadOnlyCollection<IWebElement> deleteRecord = driver.FindElements(By.XPath("//a[contains(text(),'Delete')]"));
deleteRecord[0].Click();
//Confirming ok from the delete alert box
driver.SwitchTo().Alert().Accept();

void checkTestPassed(string str)
{
    //getting all the rows from the table from the page after the edit to confirm if the edit has been done by checking the value
    getTableRowsAfterEdit = driver.FindElement(By.Id("tmsGrid"));
    getRowsAfterEditCols = getTableRowsAfterEdit.FindElements(By.TagName("tr"));
    //displaying all rows in the table on active page
    for (int i = 0; i <= getRowsAfterEditCols.Count; i++)
    {
        if (getRowsAfterEditCols[i].Text.Contains(str))
        {
            Console.WriteLine("Test Passed");
            break;
        }
    }

  

}

//logging off from the portal
helloHari = driver.FindElement(By.XPath("//a[contains(text(),'Hello hari!')]"));
helloHari.Click();
IWebElement logOff = driver.FindElement(By.XPath("//a[contains(text(),'Log off')]"));
logOff.Click();

//closing the chrome browser
driver.Close();



