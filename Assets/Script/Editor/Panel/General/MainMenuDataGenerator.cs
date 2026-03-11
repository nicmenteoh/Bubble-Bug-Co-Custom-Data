using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class MainMenuDataGenerator : MonoBehaviour
{

    [MenuItem ("Data Generator/Panel/General/Main Menu")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.mainMenu.Split (".")[0].ToLower ();

        MainMenuPanelData panel = new MainMenuPanelData
        {
            asset_id = assetId,
            ui_sprite = new MainMenuPanelData.UiSprite
            {
                background_id = "GUI91".ToLower (),
                foreground_id = "GUI92".ToLower (),
                camp_button_background_id = "GUI99".ToLower (),
                camp_icon_id = "GUI7".ToLower (),
                warehouse_button_background_id = "GUI223".ToLower (),
                warehouse_icon_id = "GUI210".ToLower (),
                food_stall_button_background_id = "GUI164".ToLower (),
                food_stall_icon_id = "GUI162".ToLower (),
                smith_button_background_id = "GUI247".ToLower (),
                smith_icon_id = "GUI245".ToLower (),
                ammo_dealer_button_background_id = "GUI264".ToLower (),
                ammo_dealer_icon_id = "GUI256".ToLower (),
                fairy_bakery_button_background_id = "GUI284".ToLower (),
                fairy_bakery_icon_id = "GUI277".ToLower (),
                crystal_lab_button_background_id = "GUI367".ToLower (),
                crystal_lab_icon_id = "GUI357".ToLower (),
                accessory_maker_button_background_id = "GUI390".ToLower (),
                accessory_maker_icon_id = "GUI358".ToLower (),
                craftsman_button_background_id = "GUI343".ToLower (),
                craftsman_icon_id = "GUI332".ToLower (),
                cage_master_button_background_id = "GUI310".ToLower (),
                cage_master_icon_id = "GUI296".ToLower (),
                inventory_button_background_id = "GUI321".ToLower (),
                inventory_icon_id = "GUI209".ToLower (),
                gallery_button_background_id = "GUI109".ToLower (),
                gallery_icon_id = "GUI103".ToLower (),
                statistic_button_background_id = "GUI469".ToLower (),
                statistic_icon_id = "GUI462".ToLower (),
                setting_button_background_id = "GUI437".ToLower (),
                setting_icon_id = "GUI104".ToLower (),
                credit_button_background_id = "GUI488".ToLower (),
                credit_icon_id = "GUI486".ToLower (),
                close_button_background_id = "GUI101".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                quit_button_background_id = "GUI100".ToLower (),
                quit_icon_id = "GUI95".ToLower (),
                scroll_view_handler_background_id = "GUI105".ToLower (),
                scroll_view_handler_id = "GUI106".ToLower (),
                quit_panel_background_id = "GUI93".ToLower (),
                quit_panel_foreground_id = "GUI94".ToLower (),
                quit_panel_quit_icon_id = "GUI95".ToLower (),
                quit_panel_yes_button_background_id = "GUI97".ToLower (),
                quit_panel_yes_icon_id = "GUI96".ToLower (),
                quit_panel_no_button_background_id = "GUI98".ToLower (),
                quit_panel_no_icon_id = "GUI87".ToLower ()
            },
            text_visual = new MainMenuPanelData.TextVisual
            {
                menu = "255,255,255,255",
                camp_button = "255,255,255,255",
                warehouse_button = "255,255,255,255",
                food_stall_button = "255,255,255,255",
                smith_button = "255,255,255,255",
                ammo_dealer_button = "255,255,255,255",
                fairy_bakery_button = "255,255,255,255",
                crystal_lab_button = "255,255,255,255",
                accessory_maker_button = "255,255,255,255",
                craftsman_button = "255,255,255,255",
                cage_master_button = "255,255,255,255",
                inventory_button = "255,255,255,255",
                gallery_button = "255,255,255,255",
                statistic_button = "255,255,255,255",
                setting_button = "255,255,255,255",
                credit_button = "255,255,255,255",
                close_button = "255,255,255,255",
                quit_button = "255,255,255,255",
                quit_message = "255,255,255,255",
                yes_button = "255,255,255,255",
                no_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.mainMenu}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Main Menu Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.mainMenu}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
