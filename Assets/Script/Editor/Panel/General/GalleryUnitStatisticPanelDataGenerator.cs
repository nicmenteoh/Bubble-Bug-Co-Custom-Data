using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class GalleryUnitStatisticPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Gallery Unit Statistic")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.galleryUnitStatistic.Split (".")[0].ToLower ();

        GalleryUnitStatisticPanelData panel = new GalleryUnitStatisticPanelData
        {
            asset_id = assetId,
            material_sprite = new GalleryUnitStatisticPanelData.MaterialSprite
            {
                reputation_icon_id = "MAT2".ToLower ()
            },
            ui_sprite = new GalleryUnitStatisticPanelData.UiSprite
            {
                background_id = "GUI117".ToLower (),
                midground_id = "GUI118".ToLower (),
                scroll_view_background_id = "GUI142".ToLower (),
                scroll_view_handler_background_id = "GUI143".ToLower (),
                scroll_view_handler_id = "GUI144".ToLower (),
                thumbnail_background_id = "GUI119".ToLower (),
                portrait_background_id = "GUI148".ToLower (),
                elemental_icon_id = "GUI120".ToLower (),
                strength_icon_id = "GUI16".ToLower (),
                rage_icon_id = "GUI18".ToLower (),
                first_seperator_id = "GUI121".ToLower (),
                size_icon_id = "GUI61".ToLower (),
                encounter_icon_id = "GUI125".ToLower (),
                catch_rate_icon_id = "GUI19".ToLower (),
                catch_rate_bar_background_id = "GUI123".ToLower (),
                catch_rate_bar_id = "GUI124".ToLower (),
                death_rate_icon_id = "GUI8".ToLower (),
                death_rate_bar_background_id = "GUI123".ToLower (),
                death_rate_bar_id = "GUI124".ToLower (),
                coin_reward_icon_id = "GUI126".ToLower (),
                reputation_reward_icon_id = "GUI127".ToLower (),
                material_gather_icon_id = "GUI128".ToLower (),
                royal_encounter_icon_id = "GUI59".ToLower (),
                royal_catch_rate_icon_id = "GUI129".ToLower (),
                royal_catch_rate_bar_background_id = "GUI123".ToLower (),
                royal_catch_rate_bar_id = "GUI124".ToLower (),
                second_seperator_id = "GUI121".ToLower (),
                third_seperator_id = "GUI121".ToLower (),
                loot_poll_bar_background_id = "GUI330".ToLower (),
                loot_poll_bar_id = "GUI331".ToLower (),
                fourth_seperator_id = "GUI121".ToLower (),
                unknown_icon_id = "GUI71".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower ()
            },
            text_visual = new GalleryUnitStatisticPanelData.TextVisual
            {
                close_button = "255,255,255,255",
                unit_name = "255,255,255,255",
                elemental = "255,255,255,255",
                strength = "255,255,255,255",
                reputation = "255,255,255,255",
                rage = "255,255,255,255",
                size = "255,255,255,255",
                encounter = "255,255,255,255",
                catch_rate = "255,255,255,255",
                death_rate = "255,255,255,255",
                coin_reward = "255,255,255,255",
                reputation_reward = "255,255,255,255",
                material_gather = "255,255,255,255",
                royal_encounter = "255,255,255,255",
                royal_catch_rate = "255,255,255,255",
                loot = "255,255,255,255",
                loot_material = "255,255,255,255",
                no_loot = "204,204,204,255",
                locate_at = "255,255,255,255",
                locate_at_location = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.galleryUnitStatistic}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Gallery Unit Statistic Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.galleryUnitStatistic}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
