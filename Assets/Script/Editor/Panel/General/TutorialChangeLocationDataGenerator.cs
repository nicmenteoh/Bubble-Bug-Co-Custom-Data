using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class TutorialChangeLocationDataGenerator
{

    [MenuItem ("Data Generator/Panel/General/Tutorial Change Location")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.tutorialChangeLocation.Split (".")[0].ToLower ();

        TutorialChangeLocationPanelData panel = new TutorialChangeLocationPanelData
        {
            asset_id = assetId,
            ui_sprite = new TutorialChangeLocationPanelData.UiSprite
            {
                background_id = "GUI37".ToLower (),
                midground_id = "GUI38".ToLower (),
                select_icon_id = "GUI89".ToLower (),
                scroll_view_background_id = "GUI67".ToLower (),
                scroll_view_handler_background_id = "GUI63".ToLower (),
                scroll_view_handler_id = "GUI64".ToLower (),
                location_selection_background_id = "GUI81".ToLower (),
                location_selection_seperator_id = "GUI86".ToLower (),
                location_selection_location_background_id = "GUI83".ToLower (),
                location_selection_select_button_background_id = "GUI84".ToLower ()
            },
            text_visual = new TutorialChangeLocationPanelData.TextVisual
            {
                title = "255,255,255,255",
                location_selection_location = "255,255,255,255",
                location_selection_occupy_by = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.tutorialChangeLocation}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Tutorial Change Location Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.tutorialChangeLocation}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
