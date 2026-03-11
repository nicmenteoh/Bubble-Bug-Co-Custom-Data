using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class LevelUpDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Level Up")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.levelUp.Split (".")[0].ToLower ();

        LevelUpPanelData panel = new LevelUpPanelData
        {
            asset_id = assetId,
            ui_sprite = new LevelUpPanelData.UiSprite
            {
                background_id = "GUI193".ToLower (),
                rank_to_id = "GUI187".ToLower (),
                new_rank_effect_id = "GUI194".ToLower (),
                scroll_view_background_id = "GUI234".ToLower (),
                scroll_view_handler_background_id = "GUI235".ToLower (),
                scroll_view_handler_id = "GUI236".ToLower (),
                close_button_background_id = "GUI191".ToLower (),
                close_icon_id = "GUI190".ToLower ()
            },
            text_visual = new LevelUpPanelData.TextVisual
            {
                congrat = "171,255,171,255",
                message = "171,255,171,255",
                old_rank = "255,255,255,255",
                new_rank = "171,255,171,255",
                item_unlock = "171,255,171,255",
                weapon = "255,255,255,255",
                crystal = "255,255,255,255",
                accessory = "255,255,255,255",
                item_name = "255,255,255,255",
                close_button = "255,255,255,255",
                no_info = "200,200,200,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.levelUp}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Level Up Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.levelUp}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
