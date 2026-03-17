using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class StatisticPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Statistic")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.statistic.Split (".")[0].ToLower ();

        StatisticPanelData panel = new StatisticPanelData
        {
            asset_id = assetId,
            ui_sprite = new StatisticPanelData.UiSprite
            {
                location_background_id = "GUI465".ToLower (),
                background_id = "GUI466".ToLower (),
                gameplay_statistic_button_background_id = "GUI467".ToLower (),
                gameplay_statistic_icon_id = "GUI463".ToLower (),
                discovery_statistic_button_background_id = "GUI467".ToLower (),
                discovery_statistic_icon_id = "GUI464".ToLower ()
            },
            text_visual = new StatisticPanelData.TextVisual
            {
                statistic = "255,255,255,255",
                gameplay_statistic = "255,255,255,255",
                discovery_statistic = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.statistic}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Statistic Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.statistic}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
