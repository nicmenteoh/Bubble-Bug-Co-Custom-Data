using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class GalleryWeaponPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Gallery Weapon")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.galleryWeapon.Split (".")[0].ToLower ();

        GalleryWeaponPanelData panel = new GalleryWeaponPanelData
        {
            asset_id = assetId,
            ui_sprite = new GalleryWeaponPanelData.UiSprite
            {
                background_id = "GUI107".ToLower (),
                scroll_view_background_id = "GUI112".ToLower (),
                scroll_view_handler_background_id = "GUI113".ToLower (),
                scroll_view_handler_id = "GUI114".ToLower (),
                weapon_button_background_id = "GUI115".ToLower (),
                back_button_background_id = "GUI101".ToLower (),
                back_icon_id = "GUI76".ToLower ()
            },
            text_visual = new GalleryWeaponPanelData.TextVisual
            {
                select_weapon = "255,255,255,255",
                weapon_button = "255,255,255,255",
                back_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.galleryWeapon}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Gallery Weapon Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.galleryWeapon}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
