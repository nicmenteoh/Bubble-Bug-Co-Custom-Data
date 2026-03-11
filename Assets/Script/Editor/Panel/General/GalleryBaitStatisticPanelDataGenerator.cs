using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class GalleryBaitStatisticPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Gallery Bait Statistic")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.galleryBaitStatistic.Split (".")[0].ToLower ();

        GalleryBaitStatisticPanelData panel = new GalleryBaitStatisticPanelData
        {
            asset_id = assetId,
            ui_sprite = new GalleryBaitStatisticPanelData.UiSprite
            {
                background_id = "GUI117".ToLower (),
                midground_id = "GUI118".ToLower (),
                scroll_view_background_id = "GUI142".ToLower (),
                scroll_view_handler_background_id = "GUI143".ToLower (),
                scroll_view_handler_id = "GUI144".ToLower (),
                thumbnail_background_id = "GUI119".ToLower (),
                portrait_background_id = "GUI148".ToLower (),
                first_seperator_id = "GUI121".ToLower (),
                used_icon_id = "GUI156".ToLower (),
                attractive_rate_icon_id = "GUI154".ToLower (),
                attractive_rate_bar_background_id = "GUI123".ToLower (),
                attractive_rate_bar_id = "GUI124".ToLower (),
                expected_attractive_rate_point_id = "GUI155".ToLower (),
                second_seperator_id = "GUI121".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower ()
            },
            text_visual = new GalleryBaitStatisticPanelData.TextVisual
            {
                bait_name = "255,255,255,255",
                used = "255,255,255,255",
                attractive_rate = "255,255,255,255",
                unit_family_attractive_rate = "255,255,255,255",
                close_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.galleryBaitStatistic}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Gallery Bait Statistic Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.galleryBaitStatistic}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
