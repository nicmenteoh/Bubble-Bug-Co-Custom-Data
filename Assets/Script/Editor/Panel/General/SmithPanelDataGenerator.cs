using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class SmithPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Smith")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.smith.Split (".")[0].ToLower ();

        SmithPanelData panel = new SmithPanelData
        {
            asset_id = assetId,
            intro_id = "INT12".ToLower (),
            material_sprite = new SmithPanelData.MaterialSprite
            {
                coin_id = "MAT1".ToLower ()
            },
            ui_sprite = new SmithPanelData.UiSprite
            {
                location_background_id = "GUI238".ToLower (),
                background_id = "GUI239".ToLower (),
                scroll_view_background_id = "GUI240".ToLower (),
                scroll_view_handler_background_id = "GUI241".ToLower (),
                scroll_view_handler_id = "GUI242".ToLower (),
                weapon_button_background_id = "GUI243".ToLower (),
                elemental_button_background_id = "GUI244".ToLower (),
                selected_search_elemental_icon_id = "GUI96".ToLower ()
            },
            text_visual = new SmithPanelData.TextVisual
            {
                smith = "255,255,255,255",
                weapon_name = "255,255,255,255",
                cost = "255,255,255,255",
                no_weapon = "200,167,133,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.smith}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Smith Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.smith}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
