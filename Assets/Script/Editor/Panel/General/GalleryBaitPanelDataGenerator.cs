using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class GalleryBaitPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Gallery Bait")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.galleryBait.Split (".")[0].ToLower ();

        GalleryBaitPanelData panel = new GalleryBaitPanelData
        {
            asset_id = assetId,
            ui_sprite = new GalleryBaitPanelData.UiSprite
            {
                background_id = "GUI107".ToLower (),
                scroll_view_background_id = "GUI112".ToLower (),
                scroll_view_handler_background_id = "GUI113".ToLower (),
                scroll_view_handler_id = "GUI114".ToLower (),
                bait_button_background_id = "GUI115".ToLower (),
                back_button_background_id = "GUI101".ToLower (),
                back_icon_id = "GUI76".ToLower ()
            },
            text_visual = new GalleryBaitPanelData.TextVisual
            {
                select_bait = "255,255,255,255",
                bait_button = "255,255,255,255",
                back_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.galleryBait}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Gallery Bait Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.galleryBait}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
