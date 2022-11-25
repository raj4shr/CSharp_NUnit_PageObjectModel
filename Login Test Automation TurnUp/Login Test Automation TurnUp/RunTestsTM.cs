


namespace Login_Test_Automation_TurnUp;

[TestFixture]
public class RunTestsTM : SetupCommonClassFolder.WebDriver
{
    
    [Test]
    public void createNewTimeandMaterial()
    {
        TimeAndMaterial gotoTimeAndMaterial = new TimeAndMaterial();
        gotoTimeAndMaterial.gotoTimeAndMaterial(chromeDriver);
        NewTimeAndMaterial createNewTimeAndMaterial = new();
        createNewTimeAndMaterial.createNewTandM(chromeDriver);
    }

    [Test]
    public void editTimeandMaterialRow()
    {
        TimeAndMaterial gotoTimeAndMaterial = new TimeAndMaterial();
        gotoTimeAndMaterial.gotoTimeAndMaterial(chromeDriver);
        EditTandM editTM = new();
        editTM.editTimeAndMaterial(chromeDriver);
    }

    [Test]
    public void DragAndDropByColumnName()
    {
        TimeAndMaterial gotoTimeAndMaterial = new TimeAndMaterial();
        gotoTimeAndMaterial.gotoTimeAndMaterial(chromeDriver);
        DragAndDrop DaD = new();
        DaD.dragAnddrop(chromeDriver);
    }

    [Test]
    public void DragAndDropClose()
    {
        TimeAndMaterial gotoTimeAndMaterial = new TimeAndMaterial();
        gotoTimeAndMaterial.gotoTimeAndMaterial(chromeDriver);
        DragAndDrop DaD = new();
        DaD.dragAnddropClose(chromeDriver);
    }

    [Test]
    public void DeleteTimeAndMaterialRecord()
    {
        TimeAndMaterial gotoTimeAndMaterial = new TimeAndMaterial();
        gotoTimeAndMaterial.gotoTimeAndMaterial(chromeDriver);
        DeleteTimeAndMaterial deleteTimeAndMaterialRow = new();
        deleteTimeAndMaterialRow.deleteTAM(chromeDriver);
    }

    
}
