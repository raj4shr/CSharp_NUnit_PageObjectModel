using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Test_Automation_TurnUp.Pages;

[TestFixture]
public class RunTests : WebDriver
{
    [SetUp]
    public void login()
    {
        chromeDriver = new ChromeDriver();
        PortalLogin pLogin = new(chromeDriver);
        TimeAndMaterial gotoTimeAndMaterial = new TimeAndMaterial();
        gotoTimeAndMaterial.gotoTimeAndMaterial(chromeDriver);
    }

    [Test]
    public void createNewTimeandMaterial()
    {
        NewTimeAndMaterial createNewTimeAndMaterial = new();
        createNewTimeAndMaterial.createNewTandM(chromeDriver);
    }

    [Test]
    public void editTimeandMaterialRow() 
    {
        EditTandM editTimeAndMaterial = new();
        editTimeAndMaterial.editTimeAndMaterial(chromeDriver);
    }

    [Test]
    public void DragAndDropByColumnName()
    {
        DragAndDrop DaD = new();
        DaD.dragAnddrop(chromeDriver);
    }

    [Test]
    public void DragAndDropClose()
    {
        DragAndDrop DaD = new();
        DaD.dragAnddrop(chromeDriver);
        DragAndDropClose DaDC = new();
        DaDC.closeDragandDrop(chromeDriver);
    }

    [Test]
    public void DeleteTimeAndMaterialRecord()
    {
        DeleteTimeAndMaterial deleteTimeAndMaterialRow = new();
        deleteTimeAndMaterialRow.deleteTAM(chromeDriver);
    }

    [TearDown]
    public void CloseTestAutomation()
    {
        chromeDriver.Quit();
    }
}
