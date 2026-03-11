using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class AmmoDealerAmmoPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Ammo Dealer Ammo")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.ammoDealerAmmo.Split(".")[0].ToLower ();

        AmmoDealerAmmoPanelData panel = new AmmoDealerAmmoPanelData
        {
            asset_id = assetId,
            material_sprite = new AmmoDealerAmmoPanelData.MaterialSprite
            {
                coin_id = "MAT1".ToLower ()
            },
            ui_sprite = new AmmoDealerAmmoPanelData.UiSprite
            {
                background_id = "GUI255".ToLower (),
                scroll_view_background_id = "GUI257".ToLower (),
                scroll_view_handler_background_id = "GUI258".ToLower (),
                scroll_view_handler_id = "GUI259".ToLower (),
                ammo_button_background_id = "GUI260".ToLower (),
                back_button_background_id = "GUI101".ToLower (),
                back_icon_id = "GUI76".ToLower ()
            },
            text_visual = new AmmoDealerAmmoPanelData.TextVisual
            {
                ammo_dealer = "255,255,255,255",
                ammo_name = "255,255,255,255",
                cost = "255,255,255,255",
                back_button = "230,204,153,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.ammoDealerAmmo}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Ammo Dealer Ammo Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.ammoDealerAmmo}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
