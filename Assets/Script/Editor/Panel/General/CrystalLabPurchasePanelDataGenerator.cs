using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class CrystalLabPurchasePanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Crystal Lab Purchase")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.crystalLabPurchase.Split (".")[0].ToLower ();

        CrystalLabPurchasePanelData panel = new CrystalLabPurchasePanelData
        {
            asset_id = assetId,
            material_sprite = new CrystalLabPurchasePanelData.MaterialSprite
            {
                coin_id = "MAT1".ToLower ()
            },
            dialogue = new CrystalLabPurchasePanelData.Dialogue
            {
                character_id = "CHA11".ToLower (),
                position_LR = "L".ToLower ()
            },
            ui_sprite = new CrystalLabPurchasePanelData.UiSprite
            {
                background_id = "GUI170".ToLower (),
                midground_id = "GUI368".ToLower (),
                purchase_button_background_id = "GUI184".ToLower (),
                purchase_icon_id = "GUI183".ToLower (),
                quantity_switch_button_background_id = "GUI374".ToLower (),
                quantity_switch_icon_id = "GUI177".ToLower (),
                next_effect_button_background_id = "GUI374".ToLower (),
                next_effect_icon_id = "GUI379".ToLower (),
                previous_effect_button_background_id = "GUI374".ToLower (),
                previous_effect_icon_id = "GUI380".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                info_button_background_id = "GUI226".ToLower (),
                scroll_view_background_id = "GUI370".ToLower (),
                scroll_view_handler_background_id = "GUI371".ToLower (),
                scroll_view_handler_id = "GUI372".ToLower (),
                thumbnail_background_id = "GUI369".ToLower (),
                owned_icon_id = "GUI176".ToLower (),
                quantity_slide_bar_background_id = "GUI375".ToLower (),
                quantity_slide_bar_id = "GUI376".ToLower (),
                quantity_slide_bar_handler_id = "GUI377".ToLower (),
                quantity_input_background_id = "GUI373".ToLower (),
                purchase_success_background_id = "GUI185".ToLower (),
                purchase_success_midground_id = "GUI192".ToLower (),
                purchase_success_dialogue_background_id = "GUI378".ToLower (),
                purchase_success_owned_quantity_to_id = "GUI187".ToLower (),
                purchase_success_crystal_thumbnail_background_id = "GUI369".ToLower (),
                purchase_success_close_button_background_id = "GUI191".ToLower (),
                purchase_success_close_icon_id = "GUI190".ToLower ()
            },
            text_visual = new CrystalLabPurchasePanelData.TextVisual
            {
                crystal_name = "255,255,255,255",
                owned = "255,255,255,255",
                effect = "255,255,255,255",
                material_require = "255,255,255,255",
                no_material_require = "230,183,206,255",
                material_name = "255,255,255,255",
                material_quantity = "255,255,255,255",
                material_sufficient = "171,255,171,255",
                material_insufficient = "255,171,171,255",
                quantity = "255,255,255,255",
                quantity_prompt = "230,207,218,128",
                quantity_input = "230,207,218,255",
                quantity_available = "255,255,255,255",
                slide_bar_quantity = "255,255,255,255",
                coin_name = "255,255,255,255",
                coin_available = "255,255,255,255",
                purchase_quantity = "255,255,255,255",
                cannot_purchase_message = "255,171,171,255",
                purchase_button = "255,255,255,255",
                close_button = "255,255,255,255",
                purchase_success = "171,255,171,255",
                dialogue = "245,208,233,255",
                purchase_success_crystal_name = "255,255,255,255",
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

        dataPath += $"/{PanelDataFilename.crystalLabPurchase}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/crystal Lab Purchase Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.crystalLabPurchase}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
