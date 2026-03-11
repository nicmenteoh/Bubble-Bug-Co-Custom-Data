using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class GalleryFairyStatisticPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Gallery Fairy Statistic")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.galleryFairyStatistic.Split (".")[0].ToLower ();

        GalleryFairyStatisticPanelData panel = new GalleryFairyStatisticPanelData
        {
            asset_id = assetId,
            ui_sprite = new GalleryFairyStatisticPanelData.UiSprite
            {
                background_id = "GUI117".ToLower (),
                midground_id = "GUI118".ToLower (),
                fairy_scroll_view_background_id = "GUI142".ToLower (),
                fairy_scroll_view_handler_background_id = "GUI143".ToLower (),
                fairy_scroll_view_handler_id = "GUI144".ToLower (),
                fairy_thumbnail_background_id = "GUI119".ToLower (),
                fairy_portrait_background_id = "GUI148".ToLower (),
                fairy_rarity_id = "GUI199".ToLower (),
                fairy_food_icon_id = "GUI133".ToLower (),
                strength_icon_id = "GUI16".ToLower (),
                strength_per_level_icon_id = "GUI135".ToLower (),
                max_level_icon_id = "GUI134".ToLower (),
                luck_icon_id = "GUI17".ToLower (),
                first_seperator_id = "GUI121".ToLower (),
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
                unknown_icon_id = "GUI71".ToLower (),
                next_button_background_id = "GUI138".ToLower (),
                next_icon_id = "GUI136".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                pest_scroll_view_background_id = "GUI145".ToLower (),
                pest_scroll_view_handler_background_id = "GUI146".ToLower (),
                pest_scroll_view_handler_id = "GUI147".ToLower (),
                pest_thumbnail_background_id = "GUI119".ToLower (),
                pest_seperator_id = "GUI121".ToLower (),
                first_page_background_id = "GUI139".ToLower (),
                last_page_background_id = "GUI139".ToLower (),
                normal_page_background_id = "GUI140".ToLower (),
                selected_page_background_id = "GUI141".ToLower ()
            },
            text_visual = new GalleryFairyStatisticPanelData.TextVisual
            {
                fairy_name = "255,255,255,255",
                fairy_food = "255,255,255,255",
                strength = "255,255,255,255",
                strength_per_level = "255,255,255,255",
                max_level = "255,255,255,255",
                luck = "255,255,255,255",
                effect = "255,255,255,255",
                effect_description = "255,255,255,255",
                pest_encounter = "255,255,255,255",
                pest_catch_rate = "255,255,255,255",
                pest_death_rate = "255,255,255,255",
                coin_reward = "255,255,255,255",
                reputation_reward = "255,255,255,255",
                material_gather = "255,255,255,255",
                royal_pest_encounter = "255,255,255,255",
                royal_pest_catch_rate = "255,255,255,255",
                next_button = "255,255,255,255",
                close_button = "255,255,255,255",
                no_pest_encounter = "255,255,255,255",
                pest_name = "255,255,255,255",
                first_page = "171,255,227,255",
                last_page = "171,255,227,255",
                normal_page = "171,255,227,255",
                selected_page = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.galleryFairyStatistic}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Gallery Fairy Statistic Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.galleryFairyStatistic}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
