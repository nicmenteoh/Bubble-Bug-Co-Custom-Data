using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class FoodStallPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Food Stall")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.foodStall.Split (".")[0].ToLower ();

        FoodStallPanelData panel = new FoodStallPanelData
        {
            asset_id = assetId,
            intro_id = "INT11".ToLower (),
            material_sprite = new FoodStallPanelData.MaterialSprite
            {
                coin_id = "MAT1".ToLower ()
            },
            ui_sprite = new FoodStallPanelData.UiSprite
            {
                location_background_id = "GUI161".ToLower (),
                background_id = "GUI160".ToLower (),
                scroll_view_background_id = "GUI165".ToLower (),
                scroll_view_handler_background_id = "GUI166".ToLower (),
                scroll_view_handler_id = "GUI167".ToLower (),
                bait_button_background_id = "GUI237".ToLower (),
                discount_background_id = "GUI168".ToLower (),
                discount_slash_id = "GUI169".ToLower ()
            },
            text_visual = new FoodStallPanelData.TextVisual
            {
                food_stall = "255,255,255,255",
                bait_name = "255,255,255,255",
                origin_cost = "255,255,255,255",
                discount_value = "255,255,255,255",
                discounted_cost = "128,255,128,255",
                no_bait = "180,200,133,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.foodStall}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/food Stall Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.foodStall}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
