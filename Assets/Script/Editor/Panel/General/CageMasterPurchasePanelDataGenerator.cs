using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class CageMasterPurchasePanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Cage Master Purchase")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.cageMasterPurchase.Split (".")[0].ToLower ();

        CageMasterPurchasePanelData panel = new CageMasterPurchasePanelData
        {
            asset_id = assetId,
            material_sprite = new CageMasterPurchasePanelData.MaterialSprite
            {
                coin_id = "MAT1".ToLower ()
            },
            dialogue = new CageMasterPurchasePanelData.Dialogue
            {
                character_id = "CHA9".ToLower (),
                position_LR = "R".ToLower ()
            },
            ui_sprite = new CageMasterPurchasePanelData.UiSprite
            {
                background_id = "GUI170".ToLower (),
                midground_id = "GUI311".ToLower (),
                purchase_button_background_id = "GUI184".ToLower (),
                purchase_icon_id = "GUI183".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                info_button_background_id = "GUI226".ToLower (),
                scroll_view_background_id = "GUI313".ToLower (),
                scroll_view_handler_background_id = "GUI314".ToLower (),
                scroll_view_handler_id = "GUI315".ToLower (),
                thumbnail_background_id = "GUI312".ToLower (),
                cage_icon_id = "GUI19".ToLower (),
                owned_icon_id = "GUI176".ToLower (),
                purchase_success_background_id = "GUI185".ToLower (),
                purchase_success_midground_id = "GUI192".ToLower (),
                purchase_success_dialogue_background_id = "GUI316".ToLower (),
                purchase_success_owned_quantity_to_id = "GUI187".ToLower (),
                purchase_success_cage_thumbnail_background_id = "GUI312".ToLower (),
                purchase_success_close_button_background_id = "GUI191".ToLower (),
                purchase_success_close_icon_id = "GUI190".ToLower ()
            },
            text_visual = new CageMasterPurchasePanelData.TextVisual
            {
                cage_name = "255,255,255,255",
                owned = "255,255,255,255",
                material_require = "255,255,255,255",
                no_material_require = "230,212,196,255",
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
                dialogue = "255,233,217,255",
                purchase_success_cage_name = "255,255,255,255",
                purchase_success_owned = "255,255,255,255",
                purchase_success_owned_old_quantity = "255,255,255,255",
                purchase_success_owned_new_quantity = "171,255,171,255",
                purchase_success_close_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.cageMasterPurchase}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Cage Master Purchase Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.cageMasterPurchase}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
