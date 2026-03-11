using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class WarehouseDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Warehouse")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.warehouse.Split (".")[0].ToLower ();

        WarehousePanelData panel = new WarehousePanelData
        {
            asset_id = assetId,
            ui_sprite = new WarehousePanelData.UiSprite
            {
                location_background_id = "GUI196".ToLower (),
                background_id = "GUI211".ToLower (),
                scroll_view_background_id = "GUI212".ToLower (),
                scroll_view_handler_background_id = "GUI213".ToLower (),
                scroll_view_handler_id = "GUI214".ToLower (),
                material_claim_background_id = "GUI217".ToLower (),
                claim_timer_bar_background_id = "GUI218".ToLower (),
                next_claim_timer_bar_id = "GUI219".ToLower (),
                full_claim_timer_bar_id = "GUI220".ToLower (),
                container_back_id = "GUI224".ToLower (),
                container_front_id = "GUI225".ToLower (),
                first_separator_id = "GUI215".ToLower (),
                info_button_background_id = "GUI226".ToLower (),
                claim_button_background_id = "GUI221".ToLower (),
                claim_icon_id = "GUI216".ToLower ()
            },
            text_visual = new WarehousePanelData.TextVisual
            {
                warehouse = "255,255,255,255",
                free_claim = "255,255,255,255",
                material_claim_quantity = "255,255,255,255",
                claim_timer = "255,255,255,255",
                claim_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.warehouse}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Warehouse Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.warehouse}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
