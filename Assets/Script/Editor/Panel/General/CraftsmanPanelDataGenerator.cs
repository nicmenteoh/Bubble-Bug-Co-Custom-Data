using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class CraftsmanPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Craftsman")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.craftsman.Split (".")[0].ToLower ();

        CraftsmanPanelData panel = new CraftsmanPanelData
        {
            asset_id = assetId,
            intro_id = "INT18".ToLower (),
            material_sprite = new CraftsmanPanelData.MaterialSprite
            {
                coin_id = "MAT1".ToLower ()
            },
            ui_sprite = new CraftsmanPanelData.UiSprite
            {
                location_background_id = "GUI333".ToLower (),
                background_id = "GUI334".ToLower (),
                scroll_view_background_id = "GUI335".ToLower (),
                scroll_view_handler_background_id = "GUI336".ToLower (),
                scroll_view_handler_id = "GUI337".ToLower (),
                material_button_background_id = "GUI338".ToLower (),
                search_input_background_id = "GUI340".ToLower (),
                search_icon_id = "GUI152".ToLower (),
                search_button_background_id = "GUI341".ToLower ()
            },
            text_visual = new CraftsmanPanelData.TextVisual
            {
                craftsman = "255,255,255,255",
                material = "255,255,255,255",
                cost = "255,255,255,255",
                search_prompt = "217,249,255,128",
                search_input = "217,249,255,255",
                search_button = "255,255,255,255",
                no_material = "173,230,230,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.craftsman}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Craftsman Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.craftsman}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
