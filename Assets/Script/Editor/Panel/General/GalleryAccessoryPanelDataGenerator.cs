using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class GalleryAccessoryPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Gallery Accessory")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.galleryAccessory.Split (".")[0].ToLower ();

        GalleryAccessoryPanelData panel = new GalleryAccessoryPanelData
        {
            asset_id = assetId,
            ui_sprite = new GalleryAccessoryPanelData.UiSprite
            {
                background_id = "GUI107".ToLower (),
                scroll_view_background_id = "GUI112".ToLower (),
                scroll_view_handler_background_id = "GUI113".ToLower (),
                scroll_view_handler_id = "GUI114".ToLower (),
                accessory_button_background_id = "GUI115".ToLower (),
                back_button_background_id = "GUI101".ToLower (),
                back_icon_id = "GUI76".ToLower ()
            },
            text_visual = new GalleryAccessoryPanelData.TextVisual
            {
                select_accessory = "255,255,255,255",
                accessory_button = "255,255,255,255",
                back_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.galleryAccessory}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Gallery Accessory Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.galleryAccessory}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
