using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class AccessoryMakerPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Accessory Maker")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.accessoryMaker.Split (".")[0].ToLower ();

        AccessoryMakerPanelData panel = new AccessoryMakerPanelData
        {
            asset_id = assetId,
            intro_id = "INT20".ToLower (),
            material_sprite = new AccessoryMakerPanelData.MaterialSprite
            {
                coin_id = "MAT1".ToLower ()
            },
            ui_sprite = new AccessoryMakerPanelData.UiSprite
            {
                location_background_id = "GUI356".ToLower (),
                background_id = "GUI382".ToLower (),
                scroll_view_background_id = "GUI383".ToLower (),
                scroll_view_handler_background_id = "GUI384".ToLower (),
                scroll_view_handler_id = "GUI385".ToLower (),
                accessory_button_background_id = "GUI386".ToLower (),
                search_input_background_id = "GUI387".ToLower (),
                search_icon_id = "GUI152".ToLower (),
                search_button_background_id = "GUI388".ToLower ()
            },
            text_visual = new AccessoryMakerPanelData.TextVisual
            {
                accessory_maker = "255,255,255,255",
                accessory = "255,255,255,255",
                cost = "255,255,255,255",
                search_prompt = "217,249,255,128",
                search_input = "217,249,255236,255",
                search_button = "255,255,255,255",
                no_accessory = "163,204,204,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.accessoryMaker}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Accessory Maker Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.accessoryMaker}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
