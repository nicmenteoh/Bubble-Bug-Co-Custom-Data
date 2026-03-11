using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class SpecialRewardDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Special Reward")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.specialReward.Split (".")[0].ToLower ();

        SpecialRewardPanelData panel = new SpecialRewardPanelData
        {
            asset_id = assetId,
            ui_sprite = new SpecialRewardPanelData.UiSprite
            {
                background_id = "GUI193".ToLower (),
                reward_effect_id = "GUI194".ToLower (),
                reward_background_id = "GUI195".ToLower (),
                close_button_background_id = "GUI191".ToLower (),
                close_icon_id = "GUI190".ToLower ()
            },
            text_visual = new SpecialRewardPanelData.TextVisual
            {
                congrat = "171,255,171,255",
                receive = "171,255,171,255",
                reward_name = "255,255,255,255",
                close_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.specialReward}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Special Reward Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.specialReward}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
