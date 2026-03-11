using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class CampPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Camp")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.camp.Split (".")[0].ToLower ();

        CampPanelData panel = new CampPanelData
        {
            asset_id = assetId,
            ui_sprite = new CampPanelData.UiSprite
            {
                background_id = "GUI31".ToLower (),
                activity_button_background_id = "GUI29".ToLower (),
                activity_icon_id = "GUI27".ToLower (),
                change_location_button_background_id = "GUI29".ToLower (),
                change_location_icon_id = "GUI26".ToLower (),
                hunt_button_background_id = "GUI28".ToLower (),
                hunt_icon_id = "GUI25".ToLower (),
                effectiveness_button_background_id = "GUI33".ToLower (),
                effectiveness_icon_id = "GUI200".ToLower (),
                history_button_background_id = "GUI33".ToLower (),
                history_icon_id = "GUI32".ToLower (),
                slot_1_background_id = "GUI10".ToLower (),
                slot_1_notification_id = "GUI30".ToLower (),
                slot_2_background_id = "GUI11".ToLower (),
                slot_2_notification_id = "GUI30".ToLower (),
                slot_3_background_id = "GUI12".ToLower (),
                slot_3_notification_id = "GUI30".ToLower (),
                slot_4_background_id = "GUI13".ToLower (),
                slot_4_notification_id = "GUI30".ToLower (),
                slot_5_background_id = "GUI14".ToLower (),
                slot_5_notification_id = "GUI30".ToLower (),
                slot_6_background_id = "GUI15".ToLower (),
                slot_6_notification_id = "GUI30".ToLower (),
                lethal_icon_id = "GUI8".ToLower (),
                extra_lethal_icon_id = "GUI9".ToLower (),
                fairy_button_background_id = "GUI20".ToLower (),
                fairy_food_button_background_id = "GUI82".ToLower (),
                crystal_button_background_id = "GUI21".ToLower (),
                bait_button_background_id = "GUI21".ToLower (),
                flavour_button_background_id = "GUI21".ToLower (),
                weapon_button_background_id = "GUI21".ToLower (),
                ammo_button_background_id = "GUI21".ToLower (),
                accessory_1_button_background_id = "GUI21".ToLower (),
                accessory_2_button_background_id = "GUI21".ToLower (),
                accessory_3_button_background_id = "GUI21".ToLower (),
                quantity_background_id = "GUI70".ToLower (),
                trap_stats_background_id = "GUI22".ToLower (),
                strength_icon_id = "GUI16".ToLower (),
                luck_icon_id = "GUI17".ToLower (),
                cage_icon_id = "GUI19".ToLower (),
                energy_icon_id = "GUI339".ToLower (),
                energy_bar_background_id = "GUI197".ToLower (),
                energy_bar_id = "GUI198".ToLower (),
                rage_icon_id = "GUI18".ToLower (),
                rage_bar_background_id = "GUI23".ToLower (),
                rage_bar_id = "GUI24".ToLower (),
                fairy_level_background_id = "GUI72".ToLower (),
                fairy_level_bar_background_id = "GUI73".ToLower (),
                fairy_level_bar_id = "GUI74".ToLower (),
                fairy_rarity_id = "GUI199".ToLower (),
                selected_slot_highlight = "GUI75".ToLower (),
                hunt_button_highlight = "GUI417".ToLower ()
            },
            text_visual = new CampPanelData.TextVisual
            {
                 camp_title = "255,255,255,255",
                 activity_button = "255,255,255,255",
                 change_location_button = "255,255,255,255",
                 hunt_button = "255,255,255,255",
                 effectiveness_button = "255,255,255,255",
                 history_button = "255,255,255,255",
                 slot = "255,255,255,255",
                 slot_1_button = "255,255,255,255",
                 slot_2_button = "255,255,255,255",
                 slot_3_button = "255,255,255,255",
                 slot_4_button = "255,255,255,255",
                 slot_5_button = "255,255,255,255",
                 slot_6_button = "255,255,255,255",
                 no_fairy = "255,255,255,255",
                 no_fairy_food = "255,255,255,255",
                 fairy_food_quantity = "255,255,255,255",
                 no_crystal = "255,255,255,255",
                 crystal_quantity = "255,255,255,255",
                 no_bait = "255,255,255,255",
                 bait_quantity = "255,255,255,255",
                 no_flavour = "255,255,255,255",
                 flavour_quantity = "255,255,255,255",
                 no_weapon = "255,255,255,255",
                 no_ammo = "255,255,255,255",
                 ammo_quantity = "255,255,255,255",
                 quantity_low = "255,171,171,255",
                 no_accessory_1 = "255,255,255,255",
                 no_accessory_2 = "255,255,255,255",
                 no_accessory_3 = "255,255,255,255",
                 strength = "255,255,255,255",
                 luck = "255,255,255,255",
                 cage = "255,255,255,255",
                 energy = "255,255,255,255",
                 rage = "255,255,255,255",
                 fairy_level = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.camp}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Camp Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.camp}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
