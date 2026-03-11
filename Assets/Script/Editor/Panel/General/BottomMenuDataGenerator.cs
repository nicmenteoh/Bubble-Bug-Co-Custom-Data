using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class BottomMenuDataGenerator
{

    [MenuItem ("Data Generator/Panel/General/Bottom Menu")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.bottomMenu.Split (".")[0].ToLower ();

        BottomMenuPanelData panel = new BottomMenuPanelData
        {
            asset_id = assetId,
            ui_sprite = new BottomMenuPanelData.UiSprite
            {
                menu_button_background_id = "GUI5".ToLower (),
                menu_icon_id = "GUI6".ToLower (),
                camp_display_background_id = "GUI4".ToLower (),
                camp_icon_id = "GUI7".ToLower (),
                warehouse_background_id = "GUI222".ToLower (),
                warehouse_icon_id = "GUI210".ToLower (),
                food_stall_background_id = "GUI163".ToLower (),
                food_stall_icon_id = "GUI162".ToLower (),
                smith_background_id = "GUI246".ToLower (),
                smith_icon_id = "GUI245".ToLower (),
                ammo_dealer_background_id = "GUI263".ToLower (),
                ammo_dealer_icon_id = "GUI256".ToLower (),
                fairy_bakery_background_id = "GUI283".ToLower (),
                fairy_bakery_icon_id = "GUI277".ToLower (),
                crystal_lab_background_id = "GUI366".ToLower (),
                crystal_lab_icon_id = "GUI357".ToLower (),
                accessory_maker_background_id = "GUI389".ToLower (),
                accessory_maker_icon_id = "GUI358".ToLower (),
                craftsman_background_id = "GUI342".ToLower (),
                craftsman_icon_id = "GUI332".ToLower (),
                cage_master_background_id = "GUI309".ToLower (),
                cage_master_icon_id = "GUI296".ToLower (),
                inventory_background_id = "GUI320".ToLower (),
                inventory_icon_id = "GUI209".ToLower (),
                gallery_background_id = "GUI108".ToLower (),
                gallery_icon_id = "GUI103".ToLower (),
                statistic_background_id = "GUI468".ToLower (),
                statistic_icon_id = "GUI462".ToLower (),
                setting_background_id = "GUI436".ToLower (),
                setting_icon_id = "GUI104".ToLower ()
            },
            text_visual = new BottomMenuPanelData.TextVisual
            {
                menu_button = "255,255,255,255",
                camp = "255,255,255,255",
                warehouse = "255,255,255,255",
                food_stall = "255,255,255,255",
                smith = "255,255,255,255",
                ammo_dealer = "255,255,255,255",
                fairy_bakery = "255,255,255,255",
                crystal_lab = "255,255,255,255",
                accessory_maker = "255,255,255,255",
                craftsman = "255,255,255,255",
                cage_master = "255,255,255,255",
                inventory = "255,255,255,255",
                gallery = "255,255,255,255",
                statistic = "255,255,255,255",
                setting = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.bottomMenu}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Bottom Menu Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.bottomMenu}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
