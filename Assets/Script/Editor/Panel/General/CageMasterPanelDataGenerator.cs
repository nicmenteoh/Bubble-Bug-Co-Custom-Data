using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class CageMasterPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Cage Master")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.cageMaster.Split (".")[0].ToLower ();

        CageMasterPanelData panel = new CageMasterPanelData
        {
            asset_id = assetId,
            intro_id = "INT16".ToLower (),
            material_sprite = new CageMasterPanelData.MaterialSprite
            {
                coin_id = "MAT1".ToLower ()
            },
            ui_sprite = new CageMasterPanelData.UiSprite
            {
                location_background_id = "GUI297".ToLower (),
                background_id = "GUI298".ToLower (),
                scroll_view_background_id = "GUI299".ToLower (),
                scroll_view_handler_background_id = "GUI300".ToLower (),
                scroll_view_handler_id = "GUI301".ToLower (),
                slot_1_button_background_id = "GUI302".ToLower (),
                slot_2_button_background_id = "GUI303".ToLower (),
                slot_3_button_background_id = "GUI304".ToLower (),
                slot_4_button_background_id = "GUI305".ToLower (),
                slot_5_button_background_id = "GUI306".ToLower (),
                slot_6_button_background_id = "GUI307".ToLower (),
                slot_select_icon_id = "GUI308".ToLower (),
                cage_icon_id = "GUI19".ToLower ()
            },
            text_visual = new CageMasterPanelData.TextVisual
            {
                cage_master = "255,255,255,255",
                cage = "255,255,255,255",
                slot = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.cageMaster}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Cage Master Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.cageMaster}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
