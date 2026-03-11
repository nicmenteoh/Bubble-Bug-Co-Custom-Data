using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class AmmoDealerPurchasePanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Ammo Dealer Purchase")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.ammoDealerPurchase.Split (".")[0].ToLower ();

        AmmoDealerPurchasePanelData panel = new AmmoDealerPurchasePanelData
        {
            asset_id = assetId,
            material_sprite = new AmmoDealerPurchasePanelData.MaterialSprite
            {
                coin_id = "MAT1".ToLower ()
            },
            dialogue = new AmmoDealerPurchasePanelData.Dialogue
            {
                character_id = "CHA6".ToLower (),
                position_LR = "R".ToLower ()
            },
            ui_sprite = new AmmoDealerPurchasePanelData.UiSprite
            {
                background_id = "GUI170".ToLower (),
                midground_id = "GUI265".ToLower (),
                purchase_button_background_id = "GUI184".ToLower (),
                purchase_icon_id = "GUI183".ToLower (),
                quantity_switch_button_background_id = "GUI271".ToLower (),
                quantity_switch_icon_id = "GUI177".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                info_button_background_id = "GUI226".ToLower (),
                scroll_view_background_id = "GUI267".ToLower (),
                scroll_view_handler_background_id = "GUI268".ToLower (),
                scroll_view_handler_id = "GUI269".ToLower (),
                thumbnail_background_id = "GUI266".ToLower (),
                strength_bonus_icon_id = "GUI149".ToLower (),
                death_icon_id = "GUI8".ToLower (),
                lethal_icon_id = "GUI8".ToLower (),
                extra_lethal_icon_id = "GUI9".ToLower (),
                owned_icon_id = "GUI176".ToLower (),
                quantity_slide_bar_background_id = "GUI272".ToLower (),
                quantity_slide_bar_id = "GUI273".ToLower (),
                quantity_slide_bar_handler_id = "GUI274".ToLower (),
                quantity_input_background_id = "GUI270".ToLower (),
                purchase_success_background_id = "GUI185".ToLower (),
                purchase_success_midground_id = "GUI192".ToLower (),
                purchase_success_dialogue_background_id = "GUI275".ToLower (),
                purchase_success_owned_quantity_to_id = "GUI187".ToLower (),
                purchase_success_ammo_thumbnail_background_id = "GUI266".ToLower (),
                purchase_success_free_ammo_icon_id = "GUI189".ToLower (),
                purchase_success_close_button_background_id = "GUI191".ToLower (),
                purchase_success_close_icon_id = "GUI190".ToLower ()
            },
            text_visual = new AmmoDealerPurchasePanelData.TextVisual
            {
                ammo_name = "255,255,255,255",
                strength_bonus = "255,255,255,255",
                lethal = "255,255,255,255",
                owned = "255,255,255,255",
                material_require = "255,255,255,255",
                no_material_require = "230,204,153,255",
                material_name = "255,255,255,255",
                material_quantity = "255,255,255,255",
                material_sufficient = "171,255,171,255",
                material_insufficient = "255,171,171,255",
                quantity = "255,255,255,255",
                quantity_prompt = "230,224,207,128",
                quantity_input = "230,224,207,255",
                quantity_available = "255,255,255,255",
                slide_bar_quantity = "255,255,255,255",
                coin_name = "255,255,255,255",
                coin_available = "255,255,255,255",
                purchase_quantity = "255,255,255,255",
                cannot_purchase_message = "255,171,171,255",
                purchase_button = "255,255,255,255",
                close_button = "255,255,255,255",
                purchase_success = "171,255,171,255",
                dialogue = "255,245,204,255",
                purchase_success_ammo_name = "255,255,255,255",
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

        dataPath += $"/{PanelDataFilename.ammoDealerPurchase}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Ammo Dealer Purchase Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.ammoDealerPurchase}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
