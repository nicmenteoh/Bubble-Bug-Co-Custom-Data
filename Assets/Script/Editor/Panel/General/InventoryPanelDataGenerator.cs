using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class InventoryPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Inventory")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.inventory.Split (".")[0].ToLower ();

        InventoryPanelData panel = new InventoryPanelData
        {
            asset_id = assetId,
            ui_sprite = new InventoryPanelData.UiSprite
            {
                background_id = "GUI170".ToLower (),
                midground_id = "GUI322".ToLower (),
                scroll_view_background_id = "GUI323".ToLower (),
                scroll_view_handler_background_id = "GUI324".ToLower (),
                scroll_view_handler_id = "GUI325".ToLower (),
                search_input_background_id = "GUI327".ToLower (),
                search_button_background_id = "GUI329".ToLower (),
                search_icon_id = "GUI152".ToLower (),
                filter_type_background_id = "GUI328".ToLower (),
                filter_all_icon_id = "GUI500".ToLower (),
                filter_general_icon_id = "GUI494".ToLower (),
                filter_currency_icon_id = "GUI497".ToLower (),
                filter_key_item_icon_id = "GUI499".ToLower (),
                filter_fairy_awaken_item_icon_id = "GUI498".ToLower (),
                filter_resources_icon_id = "GUI495".ToLower (),
                filter_activity_item_icon_id = "GUI496".ToLower (),
                selected_filter_type_icon_id = "GUI96".ToLower (),
                search_seperator_id = "GUI326".ToLower (),
                sort_button_background_id = "GUI79".ToLower (),
                sort_icon_id = "GUI77".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                info_icon_id = "GUI226".ToLower ()
            },
            text_visual = new InventoryPanelData.TextVisual
            {
                title = "255,255,255,255",
                search_prompt = "217,255,255,128",
                search_input = "217,255,255,255",
                search_button = "255,255,255,255",
                filter = "255,255,255,255",
                sort_button = "255,255,255,255",
                close_button = "255,255,255,255",
                type_header = "255,255,255,255",
                material = "255,255,255,255",
                quantity = "255,255,255,255",
                no_info = "191,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.inventory}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Inventory Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.inventory}\" has generated successful.</color>");
        Debug.Log (dataPath);

    }
}
