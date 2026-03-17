using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class SettingPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Setting")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.setting.Split (".")[0].ToLower ();

        SettingPanelData panel = new SettingPanelData
        {
            asset_id = assetId,
            ui_sprite = new SettingPanelData.UiSprite
            {
                location_background_id = "GUI435".ToLower (),
                background_id = "GUI432".ToLower (),
                gameplay_button_background_id = "GUI433".ToLower (),
                gameplay_icon_id = "GUI429".ToLower (),
                audio_button_background_id = "GUI433".ToLower (),
                audio_icon_id = "GUI459".ToLower (),
                backup_save_button_background_id = "GUI434".ToLower (),
                backup_save_icon_id = "GUI430".ToLower (),
                restore_save_button_background_id = "GUI434".ToLower (),
                restore_save_icon_id = "GUI431".ToLower (),
                delete_backup_save_button_background_id = "GUI456".ToLower (),
                delete_backup_save_icon_id = "GUI455".ToLower ()
            },
            text_visual = new SettingPanelData.TextVisual
            {
                setting = "255,255,255,255",
                version = "164,204,164,255",
                gameplay_button = "255,255,255,255",
                audio_button = "255,255,255,255",
                backup_save_button = "255,255,255,255",
                restore_save_button = "255,255,255,255",
                delete_backup_save_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.setting}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Setting Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.setting}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
