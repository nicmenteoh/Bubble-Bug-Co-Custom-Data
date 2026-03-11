using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class AmmoDealerWeaponPanelDataGenerator : MonoBehaviour
{
    [MenuItem ("Data Generator/Panel/General/Ammo Dealer Weapon")]
    static void GenerateJsonFromData ()
    {
        string assetId = PanelDataFilename.ammoDealerWeapon.Split (".")[0].ToLower ();

        AmmoDealerWeaponPanelData panel = new AmmoDealerWeaponPanelData
        {
            asset_id = assetId,
            intro_id = "INT13".ToLower (),
            ui_sprite = new AmmoDealerWeaponPanelData.UiSprite
            {
                location_background_id = "GUI254".ToLower (),
                background_id = "GUI255".ToLower (),
                scroll_view_background_id = "GUI257".ToLower (),
                scroll_view_handler_background_id = "GUI258".ToLower (),
                scroll_view_handler_id = "GUI259".ToLower (),
                weapon_button_background_id = "GUI260".ToLower (),
                elemental_button_background_id = "GUI261".ToLower (),
                selected_search_elemental_icon_id = "GUI96".ToLower (),
                addition_ammo_id = "GUI262".ToLower ()
            },
            text_visual = new AmmoDealerWeaponPanelData.TextVisual
            {
                ammo_dealer = "255,255,255,255",
                weapon_name = "255,255,255,255",
                no_weapon = "230,204,153,255"
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{PanelDataFilename.ammoDealerWeapon}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (panel));
        dataPath = $"{Application.streamingAssetsPath}/Data/Panel/Ammo Dealer Weapon Panel Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (panel, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{PanelDataFilename.ammoDealerWeapon}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
