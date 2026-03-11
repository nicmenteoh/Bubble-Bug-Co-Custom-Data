using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class SettingBackupSavePanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Setting - Backup Save")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.backupSaveSetting.Split (".")[0].ToLower ();

        SettingBackupSavePanelData panel = new SettingBackupSavePanelData
        {
            asset_id = assetId,
            ui_sprite = new SettingBackupSavePanelData.UiSprite
            {
                background_id = "GUI170".ToLower (),
                midground_id = "GUI445".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                backup_button_background_id = "GUI446".ToLower (),
                backup_icon_id = "GUI430".ToLower (),
                confirm_button_background_id = "GUI191".ToLower (),
                confirm_icon_id = "GUI190".ToLower (),
                name_input_background_id = "GUI448".ToLower ()
            },
            text_visual = new SettingBackupSavePanelData.TextVisual
            {
                backup_save = "255,255,255,255",
                close_button = "255,255,255,255",
                backup_button = "255,255,255,255",
                confirm_button = "255,255,255,255",
                backup_message = "255,255,255,255",
                name_prompt = "217,255,217,128",
                name_input = "217,255,217,255",
                backup_success = "171,255,171,255",
                backup_failed = "255,171,171,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.backupSaveSetting}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/backup Save Setting Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.backupSaveSetting}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
