using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class ChangeTrapSetupDataGenerator
{

    [MenuItem ("Data Generator/Panel/General/Change Trap Setup")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.changeTrapSetup.Split (".")[0].ToLower ();

        ChangeTrapSetupPanelData panel = new ChangeTrapSetupPanelData
        {
            asset_id = assetId,
            ui_sprite = new ChangeTrapSetupPanelData.UiSprite
            {
                background_id = "GUI37".ToLower (),
                midground_id = "GUI38".ToLower (),
                strength_icon_id = "GUI16".ToLower (),
                luck_icon_id = "GUI17".ToLower (),
                lethal_icon_id = "GUI8".ToLower (),
                extra_lethal_icon_id = "GUI9".ToLower (),
                scroll_view_background_id = "GUI67".ToLower (),
                scroll_view_handler_background_id = "GUI63".ToLower (),
                scroll_view_handler_id = "GUI64".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                remove_button_background_id = "GUI88".ToLower (),
                remove_icon_id = "GUI87".ToLower (),
                select_icon_id = "GUI89".ToLower (),
                swap_icon_id = "GUI80".ToLower (),
                search_input_background_id = "GUI150".ToLower (),
                search_button_background_id = "GUI153".ToLower (),
                search_icon_id = "GUI152".ToLower (),
                search_elemental_background_id = "GUI151".ToLower (),
                selected_search_elemental_icon_id = "GUI96".ToLower (),
                fairy_selection_background_id = "GUI81".ToLower (),
                fairy_selection_seperator_id = "GUI86".ToLower (),
                fairy_selection_fairy_background_id = "GUI83".ToLower (),
                fairy_selection_level_bar_background_id = "GUI73".ToLower (),
                fairy_selection_level_bar_id = "GUI74".ToLower (),
                fairy_selection_select_button_background_id = "GUI84".ToLower (),
                fairy_selection_swap_button_background_id = "GUI85".ToLower (),
                weapon_selection_background_id = "GUI81".ToLower (),
                weapon_selection_search_background_id = "GUI81".ToLower (),
                weapon_selection_seperator_id = "GUI86".ToLower (),
                weapon_selection_weapon_background_id = "GUI83".ToLower (),
                weapon_selection_element_background_id = "GUI90".ToLower (),
                weapon_selection_addition_ammo_id = "GUI262".ToLower (),
                weapon_selection_select_button_background_id = "GUI84".ToLower (),
                weapon_selection_swap_button_background_id = "GUI85".ToLower (),
                ammo_selection_background_id = "GUI81".ToLower (),
                ammo_selection_seperator_id = "GUI86".ToLower (),
                ammo_selection_ammo_background_id = "GUI83".ToLower (),
                ammo_selection_select_button_background_id = "GUI84".ToLower (),
                bait_selection_background_id = "GUI81".ToLower (),
                bait_selection_seperator_id = "GUI86".ToLower (),
                bait_selection_bait_background_id = "GUI83".ToLower (),
                bait_selection_select_button_background_id = "GUI84".ToLower (),
                flavour_selection_background_id = "GUI81".ToLower (),
                flavour_selection_seperator_id = "GUI86".ToLower (),
                flavour_selection_flavour_background_id = "GUI83".ToLower (),
                flavour_selection_select_button_background_id = "GUI84".ToLower (),
                location_selection_background_id = "GUI81".ToLower (),
                location_selection_seperator_id = "GUI86".ToLower (),
                location_selection_location_background_id = "GUI83".ToLower (),
                location_selection_select_button_background_id = "GUI84".ToLower (),
                crystal_selection_background_id = "GUI81".ToLower (),
                crystal_selection_seperator_id = "GUI86".ToLower (),
                crystal_selection_crystal_background_id = "GUI83".ToLower (),
                crystal_selection_select_button_background_id = "GUI84".ToLower (),
                accessory_selection_background_id = "GUI81".ToLower (),
                accessory_selection_seperator_id = "GUI86".ToLower (),
                accessory_selection_accessory_background_id = "GUI83".ToLower (),
                accessory_selection_select_button_background_id = "GUI84".ToLower (),
                accessory_selection_swap_button_background_id = "GUI85".ToLower ()
            },
            text_visual = new ChangeTrapSetupPanelData.TextVisual
            {
                title = "255,255,255,255",
                search_prompt = "217,255,217,128",
                search_input = "217,255,217,255",
                search_button = "255,255,255,255",
                select_button = "255,255,255,255",
                swap_button = "255,255,255,255",
                remove_button = "255,255,255,255",
                close_button = "255,255,255,255",
                fairy_selection_fairy = "255,255,255,255",
                fairy_selection_level = "255,255,255,255",
                fairy_selection_strength = "255,255,255,255",
                fairy_selection_luck = "255,255,255,255",
                fairy_selection_location = "255,255,255,255",
                fairy_selection_fairy_food_quantity = "255,255,255,255",
                fairy_selection_effect = "255,255,255,255",
                fairy_selection_effect_description = "255,255,255,255",
                fairy_selection_hunt_at = "255,255,255,255",
                weapon_selection_weapon = "255,255,255,255",
                weapon_selection_strength = "255,255,255,255",
                weapon_selection_ammo = "255,255,255,255",
                weapon_selection_ammo_quantity = "171,255,171,255",
                weapon_selection_used_by = "255,255,255,255",
                ammo_selection_ammo = "255,255,255,255",
                ammo_selection_strength_bonus = "255,255,255,255",
                ammo_selection_ammo_quantity = "171,255,171,255",
                bait_selection_bait = "255,255,255,255",
                bait_selection_bait_quantity = "171,255,171,255",
                flavour_selection_flavour = "255,255,255,255",
                flavour_selection_flavour_quantity = "171,255,171,255",
                location_selection_location = "255,255,255,255",
                location_selection_occupy_by = "255,255,255,255",
                crystal_selection_crystal = "255,255,255,255",
                crystal_selection_crystal_quantity = "171,255,171,255",
                crystal_selection_effect_description = "255,255,255,255",
                accessory_selection_accessory = "255,255,255,255",
                accessory_selection_effect_description = "255,255,255,255",
                accessory_selection_used_by = "255,255,255,255",
                quantity_low = "255,171,171,255",
                in_use = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.changeTrapSetup}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Change Trap Setup Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.changeTrapSetup}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
