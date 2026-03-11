using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class GalleryPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Gallery Category")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.galleryCategory.Split (".")[0].ToLower ();

        GalleryCategoryPanelData panel = new GalleryCategoryPanelData
        {
            asset_id = assetId,
            ui_sprite = new GalleryCategoryPanelData.UiSprite
            {
                location_background_id = "GUI102".ToLower (),
                background_id = "GUI107".ToLower (),
                fairy_background_id = "GUI110".ToLower (),
                fairy_icon_id = "GUI478".ToLower (),
                weapon_background_id = "GUI110".ToLower (),
                weapon_icon_id = "GUI479".ToLower (),
                bait_background_id = "GUI110".ToLower (),
                bait_icon_id = "GUI480".ToLower (),
                flavour_background_id = "GUI110".ToLower (),
                flavour_icon_id = "GUI481".ToLower (),
                crystal_background_id = "GUI110".ToLower (),
                crystal_icon_id = "GUI482".ToLower (),
                accessory_background_id = "GUI110".ToLower (),
                accessory_icon_id = "GUI483".ToLower (),
                unit_background_id = "GUI110".ToLower (),
                unit_icon_id = "GUI485".ToLower ()
            },
            text_visual = new GalleryCategoryPanelData.TextVisual
            {
                gallery = "255,255,255,255",
                fairy = "255,255,255,255",
                weapon = "255,255,255,255",
                bait = "255,255,255,255",
                flavour = "255,255,255,255",
                crystal = "255,255,255,255",
                accessory = "255,255,255,255",
                unit = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.galleryCategory}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Gallery Category Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.galleryCategory}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
