using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class SettingDeleteSavePanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Setting - Delete Save")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.deleteSaveSetting.Split (".")[0].ToLower ();

        SettingDeleteSavePanelData panel = new SettingDeleteSavePanelData
        {
            asset_id = assetId,
            ui_sprite = new SettingDeleteSavePanelData.UiSprite
            {
                background_id = "GUI170".ToLower (),
                midground_id = "GUI438".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                delete_button_background_id = "GUI447".ToLower (),
                delete_icon_id = "GUI455".ToLower (),
                scroll_view_background_id = "GUI439".ToLower (),
                scroll_view_handler_background_id = "GUI440".ToLower (),
                scroll_view_handler_id = "GUI441".ToLower (),
                backup_save_button_background_id = "GUI457".ToLower (),
                backup_save_button_highlight = "GUI450".ToLower (),
                delete_confirm_background_id = "GUI170".ToLower (),
                delete_confirm_midground_id = "GUI453".ToLower (),
                delete_confirm_attention_icon_id = "GUI452".ToLower (),
                delete_confirm_delete_failed_icon_id = "GUI454".ToLower (),
                delete_confirm_backup_save_background_id = "GUI458".ToLower (),
                yes_button_background_id = "GUI97".ToLower (),
                yes_icon_id = "GUI455".ToLower (),
                no_button_background_id = "GUI98".ToLower (),
                no_icon_id = "GUI76".ToLower ()
            },
            text_visual = new SettingDeleteSavePanelData.TextVisual
            {
                delete_save = "255,255,255,255",
                close_button = "255,255,255,255",
                delete_button = "255,255,255,255",
                backup_save_name = "255,221,204,255",
                backup_save_date = "204,183,173,255",
                select_message = "255,255,255,255",
                delete_confirm_attention = "255,213,0,255",
                delete_confirm_message = "255,255,255,255",
                delete_confirm_backup_save_name = "255,221,204,255",
                delete_confirm_backup_save_date = "204,183,173,255",
                yes_button = "255,255,255,255",
                no_button = "255,255,255,255",
                delete_confirm_delete_failed = "255,171,171,255",
                delete_confirm_delete_failed_reason = "255,171,171,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.deleteSaveSetting}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Restore Save Setting Delete.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.deleteSaveSetting}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
