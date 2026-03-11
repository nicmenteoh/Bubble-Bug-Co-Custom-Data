using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class AccessoryMakerPurchasePanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Accessory Maker Purchase")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.accessoryMakerPurchase.Split (".")[0].ToLower ();

        AccessoryMakerPurchasePanelData panel = new AccessoryMakerPurchasePanelData
        {
            asset_id = assetId,
            material_sprite = new AccessoryMakerPurchasePanelData.MaterialSprite
            {
                coin_id = "MAT1".ToLower ()
            },
            dialogue = new AccessoryMakerPurchasePanelData.Dialogue
            {
                character_id = "CHA12".ToLower (),
                position_LR = "R".ToLower ()
            },
            ui_sprite = new AccessoryMakerPurchasePanelData.UiSprite
            {
                background_id = "GUI170".ToLower (),
                midground_id = "GUI391".ToLower (),
                purchase_button_background_id = "GUI184".ToLower (),
                purchase_icon_id = "GUI183".ToLower (),
                next_effect_button_background_id = "GUI396".ToLower (),
                next_effect_icon_id = "GUI379".ToLower (),
                previous_effect_button_background_id = "GUI396".ToLower (),
                previous_effect_icon_id = "GUI380".ToLower (),
                next_accessory_button_background_id = "GUI397".ToLower (),
                next_accessory_icon_id = "GUI379".ToLower (),
                previous_accessory_button_background_id = "GUI397".ToLower (),
                previous_accessory_icon_id = "GUI380".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                info_button_background_id = "GUI226".ToLower (),
                scroll_view_background_id = "GUI393".ToLower (),
                scroll_view_handler_background_id = "GUI394".ToLower (),
                scroll_view_handler_id = "GUI395".ToLower (),
                thumbnail_background_id = "GUI392".ToLower (),
                owned_icon_id = "GUI176".ToLower (),
                purchase_success_background_id = "GUI185".ToLower (),
                purchase_success_midground_id = "GUI192".ToLower (),
                purchase_success_accessory_thumbnail_background_id = "GUI392".ToLower (),
                purchase_success_dialogue_background_id = "GUI398".ToLower (),
                purchase_success_close_button_background_id = "GUI191".ToLower (),
                purchase_success_close_icon_id = "GUI190".ToLower ()
            },
            text_visual = new AccessoryMakerPurchasePanelData.TextVisual
            {
                accessory_name = "255,255,255,255",
                owned = "255,255,255,255",
                effect = "255,255,255,255",
                base_accessory_require = "255,255,255,255",
                base_accessory_name = "255,255,255,255",
                used_by = "255,255,255,255",
                no_base_accessory_require = "184,218,230,255",
                material_require = "255,255,255,255",
                no_material_require = "184,218,230,255",
                material_name = "255,255,255,255",
                material_quantity = "255,255,255,255",
                material_sufficient = "171,255,171,255",
                material_insufficient = "255,171,171,255",
                coin_name = "255,255,255,255",
                coin_available = "255,255,255,255",
                cannot_purchase_message = "255,171,171,255",
                purchase_button = "255,255,255,255",
                close_button = "255,255,255,255",
                purchase_success = "171,255,171,255",
                dialogue = "204,255,255,255",
                purchase_success_accessory_name = "255,255,255,255",
                purchase_success_close_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.accessoryMakerPurchase}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Accessory Maker Purchase Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.accessoryMakerPurchase}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
