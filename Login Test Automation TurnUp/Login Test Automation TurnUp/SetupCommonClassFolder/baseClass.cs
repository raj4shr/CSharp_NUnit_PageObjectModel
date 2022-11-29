global using OpenQA.Selenium;
global using OpenQA.Selenium.Support.UI;
global using System.Collections.ObjectModel;
global using NUnit.Framework;
global using OpenQA.Selenium.Interactions;
global using Login_Test_Automation_TurnUp.Pages;
global using Login_Test_Automation_TurnUp.SetupCommonClassFolder;
global using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V105.Debugger;

namespace Login_Test_Automation_TurnUp;

public class turnUpPortalBaseClass : findByLocator
{
    private string[] firstName = new string[]
    {
        "Harry","Ross",
        "Bruce","Cook",
        "Carolyn","Morgan",
        "Albert","Walker",
        "Randy","Reed",
        "Larry","Barnes",
        "Lois","Wilson",
        "Jesse","Campbell",
        "Ernest","Rogers",
        "Theresa","Patterson",
        "Henry","Simmons",
        "Michelle","Perry",
        "Frank","Butler",
        "Shirley"
    };

    private string[] middleName = new string[]
    {
        "Brooks",
        "Rachel","Edwards",
        "Christopher","Perez",
        "Thomas","Baker",
        "Sara","Moore",
        "Chris","Bailey",
        "Roger","Johnson",
        "Marilyn","Thompson",
        "Anthony","Evans",
        "Julie","Hall",
        "Paula","Phillips",
        "Annie","Hernandez",
        "Dorothy","Murphy",
        "Alice","Howard"
    };

    private string[] lastName = new string[]
    {
        "Ruth","Jackson",
        "Debra","Allen",
        "Gerald","Harris",
        "Raymond","Carter",
        "Jacqueline","Torres",
        "Joseph","Nelson",
        "Carlos","Sanchez",
        "Ralph","Clark",
        "Jean","Alexander",
        "Stephen","Roberts",
        "Eric","Long",
        "Amanda","Scott",
        "Teresa","Diaz",
        "Wanda"
    };
    public IWebElement findElementOnPage(IWebDriver chromeDriver, string path, FindBy findBy)
    {
        IWebElement element = null;
        WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(30));

        if (findBy == FindBy.XPath)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(path)));
            element = chromeDriver.FindElement(By.XPath(path));
        }
        else if (findBy == FindBy.CssSelector)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(path)));
            element = chromeDriver.FindElement(By.CssSelector(path));
        }
        else if (findBy == FindBy.Id)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(path)));
            element = chromeDriver.FindElement(By.Id(path));
        }
        else if (findBy == FindBy.ClassName)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(path)));
            element = chromeDriver.FindElement(By.ClassName(path));
        }
        else if (findBy == FindBy.Name)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(path)));
            element = chromeDriver.FindElement(By.Name(path));
        }
        else if (findBy == FindBy.TagName)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.TagName(path)));
            element = chromeDriver.FindElement(By.TagName(path));
        }
        else if (findBy == FindBy.LinkText)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText(path)));
            element = chromeDriver.FindElement(By.LinkText(path));
        }

        if (element == null)
        {
            Console.WriteLine("Element not found!");
        }
        else
        {
            Console.WriteLine("Element found!");
        }
        return element;
    }

    public IWebElement findElementOnPageClickable(IWebDriver chromeDriver, string path, FindBy findBy)
    {
        IWebElement element = null;
        WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(30));

        if (findBy == FindBy.XPath)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(path)));
            element = chromeDriver.FindElement(By.XPath(path));
        }
        else if (findBy == FindBy.CssSelector)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(path)));
            element = chromeDriver.FindElement(By.CssSelector(path));
        }
        else if (findBy == FindBy.Id)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(path)));
            element = chromeDriver.FindElement(By.Id(path));
        }
        else if (findBy == FindBy.ClassName)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName(path)));
            element = chromeDriver.FindElement(By.ClassName(path));
        }
        else if (findBy == FindBy.Name)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(path)));
            element = chromeDriver.FindElement(By.Name(path));
        }
        else if (findBy == FindBy.TagName)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.TagName(path)));
            element = chromeDriver.FindElement(By.TagName(path));
        }
        else if (findBy == FindBy.LinkText)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText(path)));
            element = chromeDriver.FindElement(By.LinkText(path));
        }

        if (element == null)
        {
            Console.WriteLine("Element not found!");
        }
        else
        {
            Console.WriteLine("Element found!");
        }
        return element;
    }

    public ReadOnlyCollection<IWebElement> findElementsOnPage(IWebDriver chromeDriver, string path, FindBy findBy)
    {
        ReadOnlyCollection<IWebElement> elements = null;
        WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(30));

        if (findBy == FindBy.XPath)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(path)));
            elements = chromeDriver.FindElements(By.XPath(path));
        }
        else if (findBy == FindBy.CssSelector)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(path)));
            elements = chromeDriver.FindElements(By.CssSelector(path));
        }
        else if (findBy == FindBy.Id)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(path)));
            elements = chromeDriver.FindElements(By.Id(path));
        }
        else if (findBy == FindBy.ClassName)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(path)));
            elements = chromeDriver.FindElements(By.ClassName(path));
        }
        else if (findBy == FindBy.Name)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(path)));
            elements = chromeDriver.FindElements(By.Name(path));
        }
        else if (findBy == FindBy.TagName)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.TagName(path)));
            elements = chromeDriver.FindElements(By.TagName(path));
        }
        else if (findBy == FindBy.LinkText)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText(path)));
            elements = chromeDriver.FindElements(By.LinkText(path));
        }

        if (elements == null)
        {
            Console.WriteLine("Element not found!");
        }
        else
        {
            Console.WriteLine("Element found!");
        }
        return elements;
    }


    public void switchToFrame(IWebDriver chromeDriver, IWebElement frame)
    {
        chromeDriver.SwitchTo().Frame(frame);
    }

    public void switchToDefaultFrame(IWebDriver chromeDriver)
    {
        chromeDriver.SwitchTo().DefaultContent();
    }

    public string RandomName()
    {
        Random rand = new Random(); 
        int index=rand.Next(1, 27);
        return firstName[index] + " " + middleName[index] + " " + lastName[index];
    }

    public string firstNameRand()
    {
        Random rand = new Random();
        int index = rand.Next(1, 27);
        return firstName[index];
    }
    public string middleNameRand()
    {
        Random rand = new Random();
        int index = rand.Next(1, 27);
        return middleName[index];
    }
    public string lastNameRand()
    {
        Random rand = new Random();
        int index = rand.Next(1, 27);
        return lastName[index];
    }
    public string emailRand(string name)
    {
        return name +"@gmail.com";
    }

    public string phoneRand()
    {
        string phoneNumber = "021";
        Random rand = new Random();
        for(int i=0;i<7;i++)
        {
            phoneNumber = phoneNumber + rand.Next(0, 9);
        }
        return phoneNumber;
    }
}