using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class CrystalLabPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Crystal Lab")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.crystalLab.Split (".")[0].ToLower ();

        CrystalLabPanelData panel = new CrystalLabPanelData
        {
            asset_id = assetId,
            intro_id = "INT19".ToLower (),
            material_sprite = new CrystalLabPanelData.MaterialSprite
            {
                coin_id = "MAT1".ToLower ()
            },
            ui_sprite = new CrystalLabPanelData.UiSprite
            {
                location_background_id = "GUI355".ToLower (),
                background_id = "GUI359".ToLower (),
                scroll_view_background_id = "GUI360".ToLower (),
                scroll_view_handler_background_id = "GUI361".ToLower (),
                scroll_view_handler_id = "GUI362".ToLower (),
                material_button_background_id = "GUI363".ToLower (),
                search_input_background_id = "GUI364".ToLower (),
                search_icon_id = "GUI152".ToLower (),
                search_button_background_id = "GUI365".ToLower ()
            },
            text_visual = new CrystalLabPanelData.TextVisual
            {
                crystal_lab = "255,255,255,255",
                crystal = "255,255,255,255",
                cost = "255,255,255,255",
                search_prompt = "255,217,236,128",
                search_input = "255,217,236,255",
                search_button = "255,255,255,255",
                no_crystal = "255,178,217,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.crystalLab}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Crystal Lab Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.crystalLab}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
