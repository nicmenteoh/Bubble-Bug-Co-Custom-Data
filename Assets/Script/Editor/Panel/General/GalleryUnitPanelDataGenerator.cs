using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class GalleryUnitPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Gallery Unit")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.galleryUnit.Split (".")[0].ToLower ();

        GalleryUnitPanelData panel = new GalleryUnitPanelData
        {
            asset_id = assetId,
            ui_sprite = new GalleryUnitPanelData.UiSprite
            {
                background_id = "GUI107".ToLower (),
                scroll_view_background_id = "GUI112".ToLower (),
                scroll_view_handler_background_id = "GUI113".ToLower (),
                scroll_view_handler_id = "GUI114".ToLower (),
                royal_icon_id = "GUI59".ToLower (),
                unit_button_background_id = "GUI115".ToLower (),
                back_button_background_id = "GUI101".ToLower (),
                back_icon_id = "GUI76".ToLower ()
            },
            text_visual = new GalleryUnitPanelData.TextVisual
            {
                select_unit = "255,255,255,255",
                unit_button = "255,255,255,255",
                back_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.galleryUnit}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Gallery Unit Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.galleryUnit}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
