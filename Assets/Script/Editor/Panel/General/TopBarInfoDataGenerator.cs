using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class TopBarInfoDataGenerator
{

    [MenuItem ("Data Generator/Panel/General/Top Bar Info")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.topBarInfo.Split (".")[0].ToLower ();

        TopBarInfoPanelData panel = new TopBarInfoPanelData
        {
            asset_id = assetId,
            material_sprite = new TopBarInfoPanelData.MaterialSprite
            {
                coin_id = "MAT1".ToLower (),
                reputation_id = "MAT2".ToLower ()
            },
            ui_sprite = new TopBarInfoPanelData.UiSprite
            {
                background_id = "GUI1".ToLower (),
                foreground_id = "GUI130".ToLower (),
                rank_bar_background_id = "GUI2".ToLower (),
                rank_bar_id = "GUI3".ToLower ()
            },
            text_visual = new TopBarInfoPanelData.TextVisual
            {
                rank = "255,255,255,255",
                coin = "255,255,255,255",
                reputation = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.topBarInfo}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Top Bar Info Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.topBarInfo}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
