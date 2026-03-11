using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class StatisticDiscoveryPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Statistic - Discovery")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.discoveryStatistic.Split (".")[0].ToLower ();

        DiscoveryStatisticPanelData panel = new DiscoveryStatisticPanelData
        {
            asset_id = assetId,
            ui_sprite = new DiscoveryStatisticPanelData.UiSprite
            {
                background_id = "GUI117".ToLower (),
                midground_id = "GUI118".ToLower (),
                scroll_view_background_id = "GUI474".ToLower (),
                scroll_view_handler_background_id = "GUI475".ToLower (),
                scroll_view_handler_id = "GUI476".ToLower (),
                fairy_icon_id = "GUI478".ToLower (),
                weapon_icon_id = "GUI479".ToLower (),
                ammo_icon_id = "GUI484".ToLower (),
                bait_icon_id = "GUI480".ToLower (),
                flavour_icon_id = "GUI481".ToLower (),
                crystal_icon_id = "GUI482".ToLower (),
                accessory_icon_id = "GUI483".ToLower (),
                material_icon_id = "GUI493".ToLower (),
                bug_icon_id = "GUI485".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower ()
            },
            text_visual = new DiscoveryStatisticPanelData.TextVisual
            {
                discovery_statistic = "255,255,255,255",
                fairy = "255,255,255,255",
                weapon = "255,255,255,255",
                ammo = "255,255,255,255",
                bait = "255,255,255,255",
                flavour = "255,255,255,255",
                crystal = "255,255,255,255",
                accessory = "255,255,255,255",
                material = "255,255,255,255",
                bug = "255,255,255,255",
                location_bug = "255,255,255,255",
                close_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.discoveryStatistic}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Discovery Statistic Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.discoveryStatistic}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
