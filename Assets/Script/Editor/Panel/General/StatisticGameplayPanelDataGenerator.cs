using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class StatisticGameplayPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Statistic - Gameplay")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.gameplayStatistic.Split (".")[0].ToLower ();

        GameplayStatisticPanelData panel = new GameplayStatisticPanelData
        {
            asset_id = assetId,
            ui_sprite = new GameplayStatisticPanelData.UiSprite
            {
                background_id = "GUI117".ToLower (),
                midground_id = "GUI118".ToLower (),
                scroll_view_background_id = "GUI474".ToLower (),
                scroll_view_handler_background_id = "GUI475".ToLower (),
                scroll_view_handler_id = "GUI476".ToLower (),
                playtime_icon_id = "GUI472".ToLower (),
                hunt_since_icon_id = "GUI470".ToLower (),
                first_seperator_id = "GUI477".ToLower (),
                trap_check_icon_id = "GUI471".ToLower (),
                pest_encounter_icon_id = "GUI125".ToLower (),
                pest_catch_rate_icon_id = "GUI19".ToLower (),
                pest_catch_rate_bar_background_id = "GUI123".ToLower (),
                pest_catch_rate_bar_id = "GUI124".ToLower (),
                pest_death_rate_icon_id = "GUI8".ToLower (),
                pest_death_rate_bar_background_id = "GUI123".ToLower (),
                pest_death_rate_bar_id = "GUI124".ToLower (),
                coin_earn_icon_id = "GUI126".ToLower (),
                coin_spend_icon_id = "GUI183".ToLower (),
                reputation_earn_icon_id = "GUI127".ToLower (),
                material_gather_icon_id = "GUI128".ToLower (),
                royal_pest_encounter_icon_id = "GUI59".ToLower (),
                royal_pest_catch_rate_icon_id = "GUI129".ToLower (),
                royal_pest_catch_rate_bar_background_id = "GUI123".ToLower (),
                royal_pest_catch_rate_bar_id = "GUI124".ToLower (),
                close_button_background_id = "GUI78".ToLower (),
                close_icon_id = "GUI76".ToLower ()
            },
            text_visual = new GameplayStatisticPanelData.TextVisual
            {
                gameplay_statistic = "255,255,255,255",
                platyime = "255,255,255,255",
                hunt_since = "255,255,255,255",
                trap_check = "255,255,255,255",
                pest_encounter = "255,255,255,255",
                pest_catch_rate = "255,255,255,255",
                pest_death_rate = "255,255,255,255",
                coin_earn = "255,255,255,255",
                coin_spend = "255,255,255,255",
                reputation_earn = "255,255,255,255",
                material_gather = "255,255,255,255",
                royal_pest_encounter = "255,255,255,255",
                royal_pest_catch_rate = "255,255,255,255",
                close_button = "255,255,255,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.gameplayStatistic}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Gameplay Statistic Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.gameplayStatistic}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
