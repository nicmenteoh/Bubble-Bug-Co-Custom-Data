using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class FoodStallPurchasePanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Food Stall Purchase")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.foodStallPurchase.Split (".")[0].ToLower ();

        FoodStallPurchasePanelData panel = new FoodStallPurchasePanelData
        {
            asset_id = assetId,
            material_sprite = new FoodStallPurchasePanelData.MaterialSprite
            {
                coin_id = "MAT1".ToLower ()
            },
            dialogue = new FoodStallPurchasePanelData.Dialogue
            {
                character_id = "CHA4".ToLower (),
                position_LR = "L".ToLower ()
            },
            ui_sprite = new FoodStallPurchasePanelData.UiSprite
            {
                background_id = "GUI170".ToLower (),
                midground_id = "GUI171".ToLower (),
                purchase_button_background_id = "GUI184".ToLower (),
                purchase_icon_id = "GUI183".ToLower (),
                quantity_switch_button_background_id = "GUI179".ToLower (),
                quantity_switch_icon_id = "GUI177".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                info_button_background_id = "GUI226".ToLower (),
                scroll_view_background_id = "GUI173".ToLower (),
                scroll_view_handler_background_id = "GUI174".ToLower (),
                scroll_view_handler_id = "GUI175".ToLower (),
                thumbnail_background_id = "GUI172".ToLower (),
                owned_icon_id = "GUI176".ToLower (),
                quantity_slide_bar_background_id = "GUI180".ToLower (),
                quantity_slide_bar_id = "GUI181".ToLower (),
                quantity_slide_bar_handler_id = "GUI182".ToLower (),
                quantity_input_background_id = "GUI178".ToLower (),
                purchase_success_background_id = "GUI185".ToLower (),
                purchase_success_midground_id = "GUI192".ToLower (),
                purchase_success_dialogue_background_id = "GUI186".ToLower (),
                purchase_success_owned_quantity_to_id = "GUI187".ToLower (),
                purchase_success_bait_thumbnail_background_id = "GUI172".ToLower (),
                purchase_success_free_bait_icon_id = "GUI189".ToLower (),
                purchase_success_close_button_background_id = "GUI191".ToLower (),
                purchase_success_close_icon_id = "GUI190".ToLower ()
            },
            text_visual = new FoodStallPurchasePanelData.TextVisual
            {
                bait_name = "255,255,255,255",
                owned = "255,255,255,255",
                material_require = "255,255,255,255",
                no_material_require = "180,200,133,255",
                material_name = "255,255,255,255",
                material_quantity = "255,255,255,255",
                material_sufficient = "171,255,171,255",
                material_insufficient = "255,171,171,255",
                quantity = "255,255,255,255",
                quantity_prompt = "223,230,207,128",
                quantity_input = "223,230,207,255",
                quantity_available = "255,255,255,255",
                slide_bar_quantity = "255,255,255,255",
                coin_name = "255,255,255,255",
                coin_available = "255,255,255,255",
                purchase_quantity = "255,255,255,255",
                cannot_purchase_message = "255,171,171,255",
                purchase_button = "255,255,255,255",
                close_button = "255,255,255,255",
                purchase_success = "171,255,171,255",
                dialogue = "236,255,191,255",
                purchase_success_bait_name = "255,255,255,255",
                purchase_success_owned = "255,255,255,255",
                purchase_success_owned_old_quantity = "255,255,255,255",
                purchase_success_owned_new_quantity = "171,255,171,255",
                purchase_success_purchase_quantity = "255,255,255,255",
                purchase_success_free_quantity = "171,255,171,255",
                purchase_success_close_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.foodStallPurchase}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/food Stall Purchase Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.foodStallPurchase}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
