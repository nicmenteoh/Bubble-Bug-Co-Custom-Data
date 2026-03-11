using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class InventoryCategoryPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Inventory Category")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.inventoryCategory.Split (".")[0].ToLower ();

        InventoryCategoryPanelData panel = new InventoryCategoryPanelData
        {
            asset_id = assetId,
            ui_sprite = new InventoryCategoryPanelData.UiSprite
            {
                location_background_id = "GUI317".ToLower (),
                background_id = "GUI318".ToLower (),
                fairy_food_background_id = "GUI319".ToLower (),
                fairy_food_icon_id = "GUI492".ToLower (),
                weapon_background_id = "GUI319".ToLower (),
                weapon_icon_id = "GUI479".ToLower (),
                ammo_background_id = "GUI319".ToLower (),
                ammo_icon_id = "GUI484".ToLower (),
                bait_background_id = "GUI319".ToLower (),
                bait_icon_id = "GUI480".ToLower (),
                flavour_background_id = "GUI319".ToLower (),
                flavour_icon_id = "GUI481".ToLower (),
                crystal_background_id = "GUI319".ToLower (),
                crystal_icon_id = "GUI482".ToLower (),
                accessory_background_id = "GUI319".ToLower (),
                accessory_icon_id = "GUI483".ToLower (),
                material_background_id = "GUI319".ToLower (),
                material_icon_id = "GUI493".ToLower ()
            },
            text_visual = new InventoryCategoryPanelData.TextVisual
            {
                inventory = "255,255,255,255",
                fairy_food = "255,255,255,255",
                weapon = "255,255,255,255",
                ammo = "255,255,255,255",
                bait = "255,255,255,255",
                flavour = "255,255,255,255",
                crystal = "255,255,255,255",
                accessory = "255,255,255,255",
                material = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.inventoryCategory}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Inventory Category Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.inventoryCategory}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
