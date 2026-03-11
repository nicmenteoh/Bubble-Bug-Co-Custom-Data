using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class CreditPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Credit")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.credit.Split (".")[0].ToLower ();

        CreditPanelData panel = new CreditPanelData
        {
            asset_id = assetId,
            ui_sprite = new CreditPanelData.UiSprite
            {
                background_id = "GUI487".ToLower ()
            },
            text_visual = new CreditPanelData.TextVisual
            {
                credit = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.credit}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Credit Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.credit}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
