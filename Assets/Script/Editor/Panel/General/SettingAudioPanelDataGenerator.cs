using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class SettingAudioPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Setting - Audio")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.audioSetting.Split (".")[0].ToLower ();

        SettingAudioPanelData panel = new SettingAudioPanelData
        {
            asset_id = assetId,
            ui_sprite = new SettingAudioPanelData.UiSprite
            {
                background_id = "GUI170".ToLower (),
                midground_id = "GUI438".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                scroll_view_background_id = "GUI439".ToLower (),
                scroll_view_handler_background_id = "GUI440".ToLower (),
                scroll_view_handler_id = "GUI441".ToLower (),
                sfx_slide_bar_background_id = "GUI460".ToLower (),
                sfx_slide_bar_id = "GUI461".ToLower (),
                sfx_slide_bar_handler_id = "GUI444".ToLower ()
            },
            text_visual = new SettingAudioPanelData.TextVisual
            {
                audio = "255,255,255,255",
                close_button = "255,255,255,255",
                volume = "255,255,255,255",
                sfx = "255,255,255,255",
                sfx_value = "255,213,0,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.audioSetting}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Audio Setting Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.audioSetting}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
