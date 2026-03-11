using ProjectPestHuntData;
using UnityEditor;

public class ActivityPanelLanguage
{

    [MenuItem ("Data Generator/Language/Activity Panel/Wood Cabin Activity Panel")]
    static void GenerateWoodCabinActivityPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<WoodCabinActivityLanguage> (PanelLanguageFilename.woodCabinActivity);
    
    [MenuItem ("Data Generator/Language/Activity Panel/Wood House Activity Panel")]
    static void GenerateWoodHouseActivityPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<WoodHouseActivityLanguage> (PanelLanguageFilename.woodHouseActivity);

}
