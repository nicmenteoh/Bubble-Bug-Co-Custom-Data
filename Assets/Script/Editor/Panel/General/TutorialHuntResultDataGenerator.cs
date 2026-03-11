using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class TutorialHuntResultDataGenerator
{

    [MenuItem ("Data Generator/Panel/General/Tutorial Hunt Result")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.tutorialHuntResult.Split (".")[0].ToLower ();

        TutorialHuntResultPanelData panel = new TutorialHuntResultPanelData
        {
            asset_id = assetId,
            reward_material = new TutorialHuntResultPanelData.RewardMaterial
            {
                coin_id = "MAT1".ToLower (),
                reputation_id = "MAT2".ToLower ()
            },
            ui_sprite = new TutorialHuntResultPanelData.UiSprite
            {
                background_id = "GUI37".ToLower (),
                midground_id = "GUI38".ToLower (),
                inactive_midground_id = "GUI39".ToLower (),
                detail_background_id = "GUI37".ToLower (),
                detail_foreground_id = "GUI47".ToLower (),
                attract_failed_icon_id = "GUI34".ToLower (),
                lethal_icon_id = "GUI8".ToLower (),
                catch_success_icon_id = "GUI19".ToLower (),
                location_background_id = "GUI44".ToLower (),
                hunt_bug_background_id = "GUI44".ToLower (),
                fairy_background_id = "GUI45".ToLower (),
                fairy_food_background_id = "GUI45".ToLower (),
                crystal_background_id = "GUI45".ToLower (),
                bait_background_id = "GUI45".ToLower (),
                flavour_background_id = "GUI45".ToLower (),
                weapon_background_id = "GUI45".ToLower (),
                ammo_background_id = "GUI45".ToLower (),
                accessory_1_background_id = "GUI45".ToLower (),
                accessory_2_background_id = "GUI45".ToLower (),
                accessory_3_background_id = "GUI45".ToLower (),
                rage_icon_id = "GUI18".ToLower (),
                rage_bar_background_id = "GUI207".ToLower (),
                rage_bar_id = "GUI208".ToLower (),
                trade_button_background_id = "GUI68".ToLower (),
                trade_icon_id = "GUI60".ToLower (),
                size_icon_id = "GUI61".ToLower (),
                royal_icon_id = "GUI59".ToLower (),
                summary_bug_background_id = "GUI62".ToLower (),
                scroll_view_background_id = "GUI67".ToLower (),
                scroll_view_handler_background_id = "GUI63".ToLower (),
                scroll_view_handler_id = "GUI64".ToLower (),
                summary_slot_background_id = "GUI48".ToLower (),
                summary_next_slot_gap_id = "GUI69".ToLower (),
                summary_message_background_id = "GUI53".ToLower (),
                summary_message_bottom_seperator_id = "GUI58".ToLower (),
                catch_alive_background_id = "GUI49".ToLower (),
                catch_alive_bottom_seperator_id = "GUI54".ToLower (),
                catch_death_background_id = "GUI50".ToLower (),
                catch_death_bottom_seperator_id = "GUI55".ToLower (),
                catch_failed_background_id = "GUI51".ToLower (),
                catch_failed_bottom_seperator_id = "GUI56".ToLower (),
                attract_failed_background_id = "GUI52".ToLower (),
                attract_failed_bottom_seperator_id = "GUI57".ToLower (),
                not_equip_icon = "GUI71".ToLower ()
            },
            text_visual = new TutorialHuntResultPanelData.TextVisual
            {
                hunt_slot = "255,255,255,255",
                summary = "255,255,255,255",
                rage = "255,255,255,255",
                trade_button = "255,255,255,255",
                summary_slot = "255,255,255,255",
                summary_bug_name = "255,255,255,255",
                size = "255,255,255,255",
                reward = "255,255,255,255",
                reward_name = "255,255,255,255",
                date = "255,255,255,204",
                message = "255,255,255,255",
                bug_portrait_bug_name = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.tutorialHuntResult}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Tutorial Hunt Result Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.tutorialHuntResult}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
