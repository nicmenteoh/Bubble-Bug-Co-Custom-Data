using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class TransitionLoadingDataGenerator
{

    [MenuItem ("Data Generator/Panel/General/Transition Loading")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.transitionLoading.Split (".")[0].ToLower ();

        TransitionLoadingPanelData panel = new TransitionLoadingPanelData
        {
            asset_id = assetId,
            ui_sprite = new TransitionLoadingPanelData.UiSprite
            {
                background_id = "GUI36".ToLower (),
                bubble_id = "GUI35".ToLower ()
            },
            text_visual = new TransitionLoadingPanelData.TextVisual
            {
                message = "255,255,255,255",
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.transitionLoading}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Transition Loading Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.transitionLoading}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
