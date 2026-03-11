using Newtonsoft.Json;
using ProjectPestHuntData;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class WoodHouseActivityDataGenerator
{

    [MenuItem ("Data Generator/Activity/Wood House")]
    static void GenerateJsonFromData ()
    {
        string assetId = ActivityDataFilename.woodHouse.Split (".")[0].ToLower ();

        WoodHouseActivityData activity = new WoodHouseActivityData
        {
            asset_id = assetId,
            initial_party_start_chance = 10,
            party_chance_increase = 40,
            units_to_start_party = new List<string> { "UNI12" },
            mud_dig_quantity = 100,
            units_to_dig_mud = new List<WoodHouseActivityData.UnitMudDig>
            {
                new WoodHouseActivityData.UnitMudDig
                {
                    unit = "UNI17", dig = 10
                },
                new WoodHouseActivityData.UnitMudDig
                {
                    unit = "UNI65", dig = 15
                }
            },
            units_to_drop_key = new List<string> { "UNI19" },
            key_to_unlock_room = "MAT21",
            key_quantity_to_unlock_room = 1,
            start_speed = 900f,
            final_speed = 0f,
            speed_increase_percentage = 4,
            speed_decrease_percentage = 3,
            material_to_slow_speed = "MAT20",
            party_unit_rage_quantity = new List<WoodHouseActivityData.UnitRageQuantity>
            {
                new WoodHouseActivityData.UnitRageQuantity { rage = 1, quantity = 30 },
                new WoodHouseActivityData.UnitRageQuantity { rage = 2, quantity = 18 },
                new WoodHouseActivityData.UnitRageQuantity { rage = 3, quantity = 10 },
                new WoodHouseActivityData.UnitRageQuantity { rage = 4, quantity = 5 },
                new WoodHouseActivityData.UnitRageQuantity { rage = 5, quantity = 2 },
            },
            party_unit_group = new List<WoodHouseActivityData.UnitSpeed>
            {
                new WoodHouseActivityData.UnitSpeed
                { 
                    units = new List<string> { "UNI58" },
                    start_speed_percentage = 100
                },
                new WoodHouseActivityData.UnitSpeed
                { 
                    units = new List<string> { "UNI18" },
                    start_speed_percentage = 95
                },
                new WoodHouseActivityData.UnitSpeed
                { 
                    units = new List<string> { "UNI57" },
                    start_speed_percentage = 90
                },
                new WoodHouseActivityData.UnitSpeed
                { 
                    units = new List<string> { "UNI63" },
                    start_speed_percentage = 85
                },
                new WoodHouseActivityData.UnitSpeed
                { 
                    units = new List<string> { "UNI59", "UNI60" },
                    start_speed_percentage = 80
                },
                new WoodHouseActivityData.UnitSpeed
                { 
                    units = new List<string> { "UNI61", "UNI54" },
                    start_speed_percentage = 75
                },
                new WoodHouseActivityData.UnitSpeed
                { 
                    units = new List<string> { "UNI20" },
                    start_speed_percentage = 70
                },
                new WoodHouseActivityData.UnitSpeed
                { 
                    units = new List<string> { "UNI62", "UNI24" },
                    start_speed_percentage = 65
                },
                new WoodHouseActivityData.UnitSpeed
                { 
                    units = new List<string> { "UNI55", "UNI56" },
                    start_speed_percentage = 55
                }
            },
            to_new_location = null,
            //to_new_location = new NewLocation
            //{
            //    location_id = "LOC2",
            //    material_to_unlock_location = "MAT22",
            //    min_activity_clear_count_to_unlock = 2
            //}
            party_start_message_id = "HRM9",
            mud_clear_message_id = "HRM10",
            unit_runaway_message_id = "HRM11",
            storage_clear_message_id = "HRM12"
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Activity";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{ActivityDataFilename.woodHouse}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (activity));
        dataPath = $"{Application.streamingAssetsPath}/Data/Activity/Wood House Activity Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (activity, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{ActivityDataFilename.woodHouse}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
