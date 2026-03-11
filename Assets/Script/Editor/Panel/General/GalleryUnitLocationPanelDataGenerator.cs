using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class GalleryUnitLocationPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Gallery Unit Location")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.galleryUnitLocation.Split (".")[0].ToLower ();

        GalleryUnitLocationPanelData panel = new GalleryUnitLocationPanelData
        {
            asset_id = assetId,
            ui_sprite = new GalleryUnitLocationPanelData.UiSprite
            {
                background_id = "GUI107".ToLower (),
                scroll_view_background_id = "GUI112".ToLower (),
                scroll_view_handler_background_id = "GUI113".ToLower (),
                scroll_view_handler_id = "GUI114".ToLower (),
                region_background_id = "GUI116".ToLower (),
                location_button_background_id = "GUI111".ToLower (),
                back_button_background_id = "GUI101".ToLower (),
                back_icon_id = "GUI76".ToLower ()
            },
            text_visual = new GalleryUnitLocationPanelData.TextVisual
            {
                select_location = "255,255,255,255",
                region = "255,255,255,255",
                location_button = "255,255,255,255",
                back_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.galleryUnitLocation}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Gallery Unit Location Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.galleryUnitLocation}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
