using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class CatchEffectivenessDataGenerator
{

    [MenuItem ("Data Generator/Panel/General/Catch Effectiveness")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.catchEffectiveness.Split (".")[0].ToLower ();

        CatchEffectivenessPanelData panel = new CatchEffectivenessPanelData
        {
            asset_id = assetId,
            ui_sprite = new CatchEffectivenessPanelData.UiSprite
            {
                background_id = "GUI37".ToLower (),
                midground_id = "GUI38".ToLower (),
                scroll_view_background_id = "GUI67".ToLower (),
                scroll_view_handler_background_id = "GUI63".ToLower (),
                scroll_view_handler_id = "GUI64".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                unit_background_id = "GUI201".ToLower (),
                unit_thumbnail_background_id = "GUI202".ToLower (),
                unit_effective_bar_background_id = "GUI203".ToLower (),
                unit_effective_bar_id = "GUI204".ToLower (),
                unit_effective_positive_value_bar_id = "GUI205".ToLower (),
                unit_effective_negative_value_bar_id = "GUI206".ToLower (),
                unknown_icon_id = "GUI71".ToLower ()
            },
            text_visual = new CatchEffectivenessPanelData.TextVisual
            {
                catch_effectiveness = "255,255,255,255",
                effective_value = "255,255,255,255",
                close_button = "255,255,255,255",
                unit_name = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.catchEffectiveness}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Catch Effectiveness Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.catchEffectiveness}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
