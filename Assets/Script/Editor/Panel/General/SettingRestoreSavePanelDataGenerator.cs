using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class SettingRestoreSavePanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Setting - Restore Save")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.restoreSaveSetting.Split (".")[0].ToLower ();

        SettingRestoreSavePanelData panel = new SettingRestoreSavePanelData
        {
            asset_id = assetId,
            ui_sprite = new SettingRestoreSavePanelData.UiSprite
            {
                background_id = "GUI170".ToLower (),
                midground_id = "GUI438".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                restore_button_background_id = "GUI447".ToLower (),
                restore_icon_id = "GUI431".ToLower (),
                scroll_view_background_id = "GUI439".ToLower (),
                scroll_view_handler_background_id = "GUI440".ToLower (),
                scroll_view_handler_id = "GUI441".ToLower (),
                backup_save_button_background_id = "GUI449".ToLower (),
                backup_save_button_highlight = "GUI450".ToLower (),
                restore_confirm_background_id = "GUI170".ToLower (),
                restore_confirm_midground_id = "GUI453".ToLower (),
                restore_confirm_attention_icon_id = "GUI452".ToLower (),
                restore_confirm_restore_failed_icon_id = "GUI454".ToLower (),
                restore_confirm_backup_save_background_id = "GUI451".ToLower (),
                yes_button_background_id = "GUI97".ToLower (),
                yes_icon_id = "GUI431".ToLower (),
                no_button_background_id = "GUI98".ToLower (),
                no_icon_id = "GUI76".ToLower ()
            },
            text_visual = new SettingRestoreSavePanelData.TextVisual
            {
                restore_save = "255,255,255,255",
                close_button = "255,255,255,255",
                restore_button = "255,255,255,255",
                backup_save_name = "204,255,230,255",
                backup_save_date = "173,204,189,255",
                select_message = "255,255,255,255",
                restore_confirm_attention = "255,213,0,255",
                restore_confirm_message = "255,255,255,255",
                restore_confirm_backup_save_name = "204,255,230,255",
                restore_confirm_backup_save_date = "173,204,189,255",
                yes_button = "255,255,255,255",
                no_button = "255,255,255,255",
                restore_confirm_restore_failed = "255,171,171,255",
                restore_confirm_restore_failed_reason = "255,171,171,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.restoreSaveSetting}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Restore Save Setting Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.restoreSaveSetting}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
