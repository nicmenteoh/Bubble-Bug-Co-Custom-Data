using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class WoodHouseActivityPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/Activity/Wood House")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.woodHouseActivity.Split (".")[0].ToLower ();

        WoodHouseActivityPanelData panel = new WoodHouseActivityPanelData
        {
            asset_id = assetId,
            ui_sprite = new WoodHouseActivityPanelData.UiSprite
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
                use_key_button_background_id = "GUI426".ToLower (),
                use_key_icon_id = "GUI427".ToLower (),
                unit_thumbnail_background_id = "GUI409".ToLower (),
                material_thumbnail_background_id = "GUI409".ToLower (),
                storage_door_background_id = "GUI418".ToLower (),
                storage_room_background_id = "GUI419".ToLower (),
                party_discovery_group_background_id = "GUI422".ToLower (),
                key_hole_group_background_id = "GUI423".ToLower (),
                key_hole_frame_id = "GUI420".ToLower (),
                key_hole_mud_id = "GUI421".ToLower (),
                room_open_group_background_id = "GUI424".ToLower (),
                party_unit_group_background_id = "GUI425".ToLower (),
                auto_equip_web_background_id = "GUI415".ToLower (),
                auto_equip_web_tick_id = "GUI416".ToLower (),
                unknown_icon_id = "GUI71".ToLower ()
            },
            text_visual = new WoodHouseActivityPanelData.TextVisual
            {
                title = "255,255,255,255",
                camp_button = "255,255,255,255",
                equip_button = "255,255,255,255",
                unequip_button = "255,255,255,255",
                craft_button = "255,255,255,255",
                use_key_button = "255,255,255,255",
                party_discovery_group = "255,255,255,255",
                key_hole_group = "255,255,255,255",
                mud_fill_rate = "255,255,255,255",
                unit_key_drop_group = "255,255,255,255",
                normal_quantity = "171,255,171,255",
                quantity_low = "255,171,171,255",
                material_to_open_door = "255,255,255,255",
                room_open_group = "255,255,255,255",
                material_to_slow_speed = "255,255,255,255",
                auto_equip_web = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.woodHouseActivity}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Wood House Activity Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.woodHouseActivity}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
