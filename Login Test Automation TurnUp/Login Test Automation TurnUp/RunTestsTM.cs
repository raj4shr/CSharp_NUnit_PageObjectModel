


namespace Login_Test_Automation_TurnUp;

[TestFixture]
public class RunTestsTM : SetupCommonClassFolder.WebDriver
{
    
    [Test,Order(1)]
    public void createNewTimeandMaterial()
    {
        TimeAndMaterial gotoTimeAndMaterial = new TimeAndMaterial();
        gotoTimeAndMaterial.gotoTimeAndMaterial(chromeDriver);
        NewTimeAndMaterial createNewTimeAndMaterial = new();
        createNewTimeAndMaterial.createNewTandM(chromeDriver);
    }

    [Test,Order(2)]
    public void editTimeandMaterialRow()
    {
        TimeAndMaterial gotoTimeAndMaterial = new TimeAndMaterial();
        gotoTimeAndMaterial.gotoTimeAndMaterial(chromeDriver);
        EditTandM editTM = new();
        editTM.editTimeAndMaterial(chromeDriver);
        editTM.checkEditTimeAndMaterial(chromeDriver);
    }

    [Test,Order(3)]
    public void DragAndDropByColumnName()
    {
        TimeAndMaterial gotoTimeAndMaterial = new TimeAndMaterial();
        gotoTimeAndMaterial.gotoTimeAndMaterial(chromeDriver);
        DragAndDrop DaD = new();
        DaD.dragAnddrop(chromeDriver);
    }

    [Test,Order(4)]
    public void DragAndDropClose()
    {
        TimeAndMaterial gotoTimeAndMaterial = new TimeAndMaterial();
        gotoTimeAndMaterial.gotoTimeAndMaterial(chromeDriver);
        DragAndDrop DaD = new();
        DaD.dragAnddropClose(chromeDriver);
    }

    [Test,Order(5)]
    public void DeleteTimeAndMaterialRecord()
    {
        TimeAndMaterial gotoTimeAndMaterial = new TimeAndMaterial();
        gotoTimeAndMaterial.gotoTimeAndMaterial(chromeDriver);
        DeleteTimeAndMaterial deleteTimeAndMaterialRow = new();
        deleteTimeAndMaterialRow.deleteTAM(chromeDriver);
    }

    
}
