using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class GalleryWeaponStatisticPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Gallery Weapon Statistic")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.galleryWeaponStatistic.Split (".")[0].ToLower ();

        GalleryWeaponStatisticPanelData panel = new GalleryWeaponStatisticPanelData
        {
            asset_id = assetId,
            ui_sprite = new GalleryWeaponStatisticPanelData.UiSprite
            {
                background_id = "GUI117".ToLower (),
                midground_id = "GUI118".ToLower (),
                weapon_scroll_view_background_id = "GUI142".ToLower (),
                weapon_scroll_view_handler_background_id = "GUI143".ToLower (),
                weapon_scroll_view_handler_id = "GUI144".ToLower (),
                weapon_thumbnail_background_id = "GUI119".ToLower (),
                weapon_portrait_background_id = "GUI148".ToLower (),
                elemental_icon_id = "GUI120".ToLower (),
                strength_icon_id = "GUI16".ToLower (),
                weapon_first_seperator_id = "GUI121".ToLower (),
                encounter_icon_id = "GUI125".ToLower (),
                catch_rate_icon_id = "GUI19".ToLower (),
                catch_rate_bar_background_id = "GUI123".ToLower (),
                catch_rate_bar_id = "GUI124".ToLower (),
                weapon_second_seperator_id = "GUI121".ToLower (),
                unknown_icon_id = "GUI71".ToLower (),
                next_button_background_id = "GUI138".ToLower (),
                next_icon_id = "GUI136".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                lethal_icon_id = "GUI8".ToLower (),
                extra_lethal_icon_id = "GUI9".ToLower (),
                ammo_scroll_view_background_id = "GUI145".ToLower (),
                ammo_scroll_view_handler_background_id = "GUI146".ToLower (),
                ammo_scroll_view_handler_id = "GUI147".ToLower (),
                ammo_thumbnail_background_id = "GUI119".ToLower (),
                ammo_portrait_background_id = "GUI148".ToLower (),
                strength_bonus_icon_id = "GUI149".ToLower (),
                death_icon_id = "GUI8".ToLower (),
                used_icon_id = "GUI125".ToLower (),
                death_rate_icon_id = "GUI8".ToLower (),
                death_rate_bar_background_id = "GUI123".ToLower (),
                death_rate_bar_id = "GUI124".ToLower (),
                ammo_first_seperator_id = "GUI121".ToLower (),
                ammo_second_seperator_id = "GUI121".ToLower (),
                first_page_background_id = "GUI139".ToLower (),
                last_page_background_id = "GUI139".ToLower (),
                normal_page_background_id = "GUI140".ToLower (),
                selected_page_background_id = "GUI141".ToLower ()
            },
            text_visual = new GalleryWeaponStatisticPanelData.TextVisual
            {
                weapon_name = "255,255,255,255",
                elemental = "255,255,255,255",
                strength = "255,255,255,255",
                encounter = "255,255,255,255",
                catch_rate = "255,255,255,255",
                ammo_name = "255,255,255,255",
                strength_bonus = "255,255,255,255",
                lethal = "255,255,255,255",
                used = "255,255,255,255",
                death_rate = "255,255,255,255",
                next_button = "255,255,255,255",
                close_button = "255,255,255,255",
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

        dataPath += $"/{PanelDataFilename.galleryWeaponStatistic}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Gallery Weapon Statistic Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.galleryWeaponStatistic}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
