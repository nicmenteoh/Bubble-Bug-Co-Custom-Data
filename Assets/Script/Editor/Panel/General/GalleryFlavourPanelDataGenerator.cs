using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class GalleryFlavourPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Gallery Flavour")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.galleryFlavour.Split (".")[0].ToLower ();

        GalleryFlavourPanelData panel = new GalleryFlavourPanelData
        {
            asset_id = assetId,
            ui_sprite = new GalleryFlavourPanelData.UiSprite
            {
                background_id = "GUI107".ToLower (),
                scroll_view_background_id = "GUI112".ToLower (),
                scroll_view_handler_background_id = "GUI113".ToLower (),
                scroll_view_handler_id = "GUI114".ToLower (),
                flavour_button_background_id = "GUI115".ToLower (),
                back_button_background_id = "GUI101".ToLower (),
                back_icon_id = "GUI76".ToLower ()
            },
            text_visual = new GalleryFlavourPanelData.TextVisual
            {
                select_flavour = "255,255,255,255",
                flavour_button = "255,255,255,255",
                back_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.galleryFlavour}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Gallery Flavour Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.galleryFlavour}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
