using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace Login_Test_Automation_TurnUp;

public class turnUpPortalBaseClass : findByLocator
{
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



}