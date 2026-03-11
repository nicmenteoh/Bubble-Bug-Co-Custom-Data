using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class FairyBakeryPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Fairy Bakery")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.fairyBakery.Split (".")[0].ToLower ();

        FairyBakeryPanelData panel = new FairyBakeryPanelData
        {
            asset_id = assetId,
            before_gift_intro_id = "INT14".ToLower (),
            after_gift_intro_id = "INT15".ToLower (),
            low_fairy_food_dialogue_id = "INT17".ToLower (),
            material_sprite = new FairyBakeryPanelData.MaterialSprite
            {
                coin_id = "MAT1".ToLower ()
            },
            ui_sprite = new FairyBakeryPanelData.UiSprite
            {
                location_background_id = "GUI276".ToLower (),
                background_id = "GUI278".ToLower (),
                scroll_view_background_id = "GUI279".ToLower (),
                scroll_view_handler_background_id = "GUI280".ToLower (),
                scroll_view_handler_id = "GUI281".ToLower (),
                fairy_food_button_background_id = "GUI282".ToLower (),
                discount_background_id = "GUI168".ToLower (),
                discount_slash_id = "GUI169".ToLower ()
            },
            text_visual = new FairyBakeryPanelData.TextVisual
            {
                fairy_bakery = "255,255,255,255",
                fairy_food_name = "255,255,255,255",
                origin_cost = "255,255,255,255",
                discount_value = "255,255,255,255",
                discounted_cost = "128,255,128,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.fairyBakery}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Fairy Bakery Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.fairyBakery}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
