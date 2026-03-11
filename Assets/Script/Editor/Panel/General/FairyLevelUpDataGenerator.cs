using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class FairyLevelUpDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Fairy Level Up")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.fairyLevelUp.Split (".")[0].ToLower ();

        FairyLevelUpPanelData panel = new FairyLevelUpPanelData
        {
            asset_id = assetId,
            ui_sprite = new FairyLevelUpPanelData.UiSprite
            {
                background_id = "GUI193".ToLower (),
                scroll_view_background_id = "GUI489".ToLower (),
                scroll_view_handler_background_id = "GUI490".ToLower (),
                scroll_view_handler_id = "GUI491".ToLower (),
                level_up_to_id = "GUI187".ToLower (),
                close_button_background_id = "GUI191".ToLower (),
                close_icon_id = "GUI190".ToLower ()
            },
            text_visual = new FairyLevelUpPanelData.TextVisual
            {
                congrat = "171,255,171,255",
                message = "171,255,171,255",
                fairy_name = "255,255,255,255",
                level = "255,255,255,255",
                level_old_value = "255,255,255,255",
                level_new_value = "171,255,171,255",
                strength = "255,255,255,255",
                strength_old_value = "255,255,255,255",
                strength_new_value = "171,255,171,255",
                close_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.fairyLevelUp}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Fairy Level Up Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.fairyLevelUp}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
