using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class RewardSummaryDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Reward Summary")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.rewardSummary.Split (".")[0].ToLower ();

        RewardSummaryPanelData panel = new RewardSummaryPanelData
        {
            asset_id = assetId,
            ui_sprite = new RewardSummaryPanelData.UiSprite
            {
                background_id = "GUI227".ToLower (),
                midground_id = "GUI228".ToLower (),
                scroll_view_background_id = "GUI229".ToLower (),
                scroll_view_handler_background_id = "GUI230".ToLower (),
                scroll_view_handler_id = "GUI231".ToLower (),
                close_button_background_id = "GUI232".ToLower (),
                close_icon_id = "GUI76".ToLower ()
            },
            text_visual = new RewardSummaryPanelData.TextVisual
            {
                title = "255,255,255,255",
                fairy_food = "255,255,255,255",
                bait = "255,255,255,255",
                flavour = "255,255,255,255",
                ammo = "255,255,255,255",
                material = "255,255,255,255",
                item_name = "255,255,255,255",
                quantity = "255,255,255,255",
                close_button = "255,255,255,255",
                no_info = "200,200,200,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.rewardSummary}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Reward Summary Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.rewardSummary}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
