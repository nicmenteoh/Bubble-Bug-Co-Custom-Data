using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class SettingGameplayPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Setting - Gameplay")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.gameplaySetting.Split (".")[0].ToLower ();

        SettingGameplayPanelData panel = new SettingGameplayPanelData
        {
            asset_id = assetId,
            ui_sprite = new SettingGameplayPanelData.UiSprite
            {
                background_id = "GUI170".ToLower (),
                midground_id = "GUI438".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                scroll_view_background_id = "GUI439".ToLower (),
                scroll_view_handler_background_id = "GUI440".ToLower (),
                scroll_view_handler_id = "GUI441".ToLower (),
                quantity_slide_bar_background_id = "GUI442".ToLower (),
                quantity_slide_bar_id = "GUI443".ToLower (),
                quantity_slide_bar_handler_id = "GUI444".ToLower ()
            },
            text_visual = new SettingGameplayPanelData.TextVisual
            {
                gameplay = "255,255,255,255",
                close_button = "255,255,255,255",
                hunt_category = "255,255,255,255",
                cage_to_check = "255,255,255,255",
                cage_quantity = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.gameplaySetting}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Gameplay Setting Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.gameplaySetting}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
