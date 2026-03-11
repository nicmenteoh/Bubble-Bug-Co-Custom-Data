using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class DialoguePanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Dialogue")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.dialogue.Split (".")[0].ToLower ();

        DialoguePanelData panel = new DialoguePanelData
        {
            asset_id = assetId,
            ui_sprite = new DialoguePanelData.UiSprite
            {
                background_id = "GUI157".ToLower (),
                dialogue_background_id = "GUI158".ToLower (),
                end_of_text_id = "GUI159".ToLower ()
            },
            text_visual = new DialoguePanelData.TextVisual
            {
                dialogye = "209,255,209,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.dialogue}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Dialogue Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.dialogue}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
