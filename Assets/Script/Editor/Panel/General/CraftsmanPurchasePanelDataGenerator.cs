using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class CraftsmanPurchasePanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Craftsman Purchase")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.craftsmanPurchase.Split (".")[0].ToLower ();

        CraftsmanPurchasePanelData panel = new CraftsmanPurchasePanelData
        {
            asset_id = assetId,
            material_sprite = new CraftsmanPurchasePanelData.MaterialSprite
            {
                coin_id = "MAT1".ToLower ()
            },
            dialogue = new CraftsmanPurchasePanelData.Dialogue
            {
                character_id = "CHA10".ToLower (),
                position_LR = "R".ToLower ()
            },
            ui_sprite = new CraftsmanPurchasePanelData.UiSprite
            {
                background_id = "GUI170".ToLower (),
                midground_id = "GUI344".ToLower (),
                purchase_button_background_id = "GUI184".ToLower (),
                purchase_icon_id = "GUI183".ToLower (),
                quantity_switch_button_background_id = "GUI350".ToLower (),
                quantity_switch_icon_id = "GUI177".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                info_button_background_id = "GUI226".ToLower (),
                scroll_view_background_id = "GUI346".ToLower (),
                scroll_view_handler_background_id = "GUI347".ToLower (),
                scroll_view_handler_id = "GUI348".ToLower (),
                thumbnail_background_id = "GUI345".ToLower (),
                owned_icon_id = "GUI176".ToLower (),
                quantity_slide_bar_background_id = "GUI351".ToLower (),
                quantity_slide_bar_id = "GUI352".ToLower (),
                quantity_slide_bar_handler_id = "GUI353".ToLower (),
                quantity_input_background_id = "GUI349".ToLower (),
                purchase_success_background_id = "GUI185".ToLower (),
                purchase_success_midground_id = "GUI192".ToLower (),
                purchase_success_dialogue_background_id = "GUI354".ToLower (),
                purchase_success_owned_quantity_to_id = "GUI187".ToLower (),
                purchase_success_material_thumbnail_background_id = "GUI345".ToLower (),
                purchase_success_close_button_background_id = "GUI191".ToLower (),
                purchase_success_close_icon_id = "GUI190".ToLower ()
            },
            text_visual = new CraftsmanPurchasePanelData.TextVisual
            {
                material_name = "255,255,255,255",
                owned = "255,255,255,255",
                material_require = "255,255,255,255",
                no_material_require = "183,224,230,255",
                craft_material_name = "255,255,255,255",
                craft_material_quantity = "255,255,255,255",
                craft_material_sufficient = "171,255,171,255",
                craft_material_insufficient = "255,171,171,255",
                quantity = "255,255,255,255",
                quantity_prompt = "207,226,230,128",
                quantity_input = "207,226,230,255",
                quantity_available = "255,255,255,255",
                slide_bar_quantity = "255,255,255,255",
                coin_name = "255,255,255,255",
                coin_available = "255,255,255,255",
                purchase_quantity = "255,255,255,255",
                cannot_purchase_message = "255,171,171,255",
                purchase_button = "255,255,255,255",
                close_button = "255,255,255,255",
                purchase_success = "171,255,171,255",
                dialogue = "209,239,245,255",
                purchase_success_material_name = "255,255,255,255",
                purchase_success_owned = "255,255,255,255",
                purchase_success_owned_old_quantity = "255,255,255,255",
                purchase_success_owned_new_quantity = "171,255,171,255",
                purchase_success_purchase_quantity = "255,255,255,255",
                purchase_success_close_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.craftsmanPurchase}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Craftsman Purchase Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.craftsmanPurchase}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
