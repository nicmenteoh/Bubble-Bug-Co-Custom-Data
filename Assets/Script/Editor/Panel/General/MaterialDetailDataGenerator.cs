using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class MaterialDetailDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Material Detail")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.materialDetail.Split (".")[0].ToLower ();

        MaterialDetailPanelData panel = new MaterialDetailPanelData
        {
            asset_id = assetId,
            ui_sprite = new MaterialDetailPanelData.UiSprite
            {
                background_id = "GUI227".ToLower (),
                midground_id = "GUI228".ToLower (),
                scroll_view_background_id = "GUI229".ToLower (),
                scroll_view_handler_background_id = "GUI230".ToLower (),
                scroll_view_handler_id = "GUI231".ToLower (),
                info_icon_id = "GUI226".ToLower (),
                close_button_background_id = "GUI232".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                food_stall_icon_id = "GUI162".ToLower (),
                smith_icon_id = "GUI245".ToLower (),
                ammo_dealer_icon_id = "GUI256".ToLower (),
                fairy_bakery_icon_id = "GUI277".ToLower (),
                material_craft_icon_id = "GUI332".ToLower (),
                crystal_lab_icon_id = "GUI357".ToLower (),
                accessory_maker_icon_id = "GUI358".ToLower ()
            },
            text_visual = new MaterialDetailPanelData.TextVisual
            {
                title = "255,255,255,255",
                purchase_craft_at = "255,255,255,255",
                craft_material = "255,255,255,255",
                use_to_craft = "255,255,255,255",
                fairy_awaken = "255,255,255,255",
                loot_at = "255,255,255,255",
                item_name = "255,255,255,255",
                quantity = "255,255,255,255",
                no_info = "200,200,200,255",
                close_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.materialDetail}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Material Detail Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.materialDetail}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
