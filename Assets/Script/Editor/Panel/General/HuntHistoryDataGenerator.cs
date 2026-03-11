using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class HuntHistoryDataGenerator
{

    [MenuItem ("Data Generator/Panel/General/Hunt History")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.huntHistory.Split (".")[0].ToLower ();

        HuntHistoryPanelData panel = new HuntHistoryPanelData
        {
            asset_id = assetId,
            reward_material = new HuntHistoryPanelData.RewardMaterial
            {
                coin_id = "MAT1".ToLower (),
                reputation_id = "MAT2".ToLower ()
            },
            ui_sprite = new HuntHistoryPanelData.UiSprite
            {
                background_id = "GUI37".ToLower (),
                midground_id = "GUI38".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower (),
                order_button_background_id = "GUI79".ToLower (),
                order_icon_id = "GUI77".ToLower (),
                attract_failed_icon_id = "GUI34".ToLower (),
                lethal_icon_id = "GUI8".ToLower (),
                catch_success_icon_id = "GUI19".ToLower (),
                size_icon_id = "GUI61".ToLower (),
                royal_icon_id = "GUI59".ToLower (),
                bug_background_id = "GUI62".ToLower (),
                scroll_view_background_id = "GUI67".ToLower (),
                scroll_view_handler_background_id = "GUI63".ToLower (),
                scroll_view_handler_id = "GUI64".ToLower (),
                bug_portrait_background_id = "GUI65".ToLower (),
                bug_portrait_bug_background_id = "GUI66".ToLower (),
                slot_background_id = "GUI48".ToLower (),
                message_background_id = "GUI53".ToLower (),
                message_bottom_seperator_id = "GUI58".ToLower (),
                catch_alive_background_id = "GUI49".ToLower (),
                catch_alive_bottom_seperator_id = "GUI54".ToLower (),
                catch_death_background_id = "GUI50".ToLower (),
                catch_death_bottom_seperator_id = "GUI55".ToLower (),
                catch_failed_background_id = "GUI51".ToLower (),
                catch_failed_bottom_seperator_id = "GUI56".ToLower (),
                attract_failed_background_id = "GUI52".ToLower (),
                attract_failed_bottom_seperator_id = "GUI57".ToLower ()
            },
            text_visual = new HuntHistoryPanelData.TextVisual
            {
                history = "255,255,255,255",
                close_button = "255,255,255,255",
                order_button = "255,255,255,255",
                slot = "255,255,255,255",
                bug_name = "255,255,255,255",
                size = "255,255,255,255",
                reward = "255,255,255,255",
                reward_name = "255,255,255,255",
                date = "255,255,255,204",
                message = "255,255,255,255",
                bug_portrait_bug_name = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.huntHistory}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Hunt History Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.huntHistory}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
