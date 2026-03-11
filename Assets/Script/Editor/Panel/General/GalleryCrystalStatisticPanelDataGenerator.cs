using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class GalleryCrystalStatisticPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Gallery Crystal Statistic")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.galleryCrystalStatistic.Split (".")[0].ToLower ();

        GalleryCrystalStatisticPanelData panel = new GalleryCrystalStatisticPanelData
        {
            asset_id = assetId,
            ui_sprite = new GalleryCrystalStatisticPanelData.UiSprite
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
                second_seperator_id = "GUI121".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                unknown_icon_id = "GUI71".ToLower ()
            },
            text_visual = new GalleryCrystalStatisticPanelData.TextVisual
            {
                crystal_name = "255,255,255,255",
                effect = "255,255,255,255",
                effect_description = "255,255,255,255",
                used = "255,255,255,255",
                close_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.galleryCrystalStatistic}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Gallery Crystal Statistic Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.galleryCrystalStatistic}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
