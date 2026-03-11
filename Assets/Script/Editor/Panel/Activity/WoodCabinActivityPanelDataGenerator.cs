using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class WoodCabinActivityPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/Activity/Wood Cabin")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.woodCabinActivity.Split (".")[0].ToLower ();

        WoodCabinActivityPanelData panel = new WoodCabinActivityPanelData
        {
            asset_id = assetId,
            ui_sprite = new WoodCabinActivityPanelData.UiSprite
            {
                background_id = "GUI31".ToLower (),
                scroll_view_background_id = "GUI399".ToLower (),
                scroll_view_handler_background_id = "GUI400".ToLower (),
                scroll_view_handler_id = "GUI401".ToLower (),
                camp_button_background_id = "GUI29".ToLower (),
                camp_icon_id = "GUI19".ToLower (),
                equip_button_background_id = "GUI402".ToLower (),
                equip_icon_id = "GUI403".ToLower (),
                unequip_button_background_id = "GUI404".ToLower (),
                unequip_icon_id = "GUI405".ToLower (),
                craft_button_background_id = "GUI406".ToLower (),
                craft_icon_id = "GUI332".ToLower (),
                wood_background_id = "GUI407".ToLower (),
                hole_id = "GUI408".ToLower (),
                unit_thumbnail_background_id = "GUI409".ToLower (),
                material_thumbnail_background_id = "GUI409".ToLower (),
                hole_discovery_group_background_id = "GUI410".ToLower (),
                unit_layer_group_background_id = "GUI411".ToLower (),
                hole_progress_background_id = "GUI412".ToLower (),
                hole_progress_id = "GUI413".ToLower (),
                bug_icon_id = "GUI414".ToLower (),
                auto_equip_lure_background_id = "GUI415".ToLower (),
                auto_equip_lure_tick_id = "GUI416".ToLower (),
                auto_hole_repair_background_id = "GUI415".ToLower (),
                auto_hole_repair_tick_id = "GUI416".ToLower (),
                unknown_icon_id = "GUI71".ToLower ()
            },
            text_visual = new WoodCabinActivityPanelData.TextVisual
            {
                title = "255,255,255,255",
                camp_button = "255,255,255,255",
                equip_button = "255,255,255,255",
                unequip_button = "255,255,255,255",
                craft_button = "255,255,255,255",
                hole_discovery_group = "255,255,255,255",
                unit_layer_group = "255,255,255,255",
                material_to_lure_and_repair = "255,255,255,255",
                normal_quantity = "171,255,171,255",
                quantity_low = "255,171,171,255",
                unit_layer = "255,255,255,255",
                unit_to_boost_repair = "255,255,255,255",
                auto_equip_lure = "255,255,255,255",
                auto_hole_repair = "255,255,255,255",
                hole_progress = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.woodCabinActivity}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Wood Cabin Activity Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.woodCabinActivity}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
