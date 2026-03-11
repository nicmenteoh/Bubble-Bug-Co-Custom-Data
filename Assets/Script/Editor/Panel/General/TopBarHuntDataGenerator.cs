using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class TopBarHuntDataGenerator
{

    [MenuItem ("Data Generator/Panel/General/Top Bar Hunt")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.topBarHunt.Split (".")[0].ToLower ();

        TopBarHuntPanelData panel = new TopBarHuntPanelData
        {
            asset_id = assetId,
            ui_sprite = new TopBarHuntPanelData.UiSprite
            {
                background_id = "GUI1".ToLower (),
                foreground_id = "GUI131".ToLower (),
                hunt_button_background_id = "GUI132".ToLower (),
                hunt_icon_id = "GUI25".ToLower (),
                slot_1_notification_id = "GUI30".ToLower (),
                slot_2_notification_id = "GUI30".ToLower (),
                slot_3_notification_id = "GUI30".ToLower (),
                slot_4_notification_id = "GUI30".ToLower (),
                slot_5_notification_id = "GUI30".ToLower (),
                slot_6_notification_id = "GUI30".ToLower ()
            },
            text_visual = new TopBarHuntPanelData.TextVisual
            {
                hunt_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.topBarHunt}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Top Bar Hunt Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.topBarHunt}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
