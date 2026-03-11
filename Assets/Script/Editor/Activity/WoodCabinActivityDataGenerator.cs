using Newtonsoft.Json;
using ProjectPestHuntData;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class WoodCabinActivityDataGenerator
{

    [MenuItem ("Data Generator/Activity/Wood Cabin")]
    static void GenerateJsonFromData ()
    {
        string assetId = ActivityDataFilename.woodCabin.Split (".")[0].ToLower ();

        WoodCabinActivityData activity = new WoodCabinActivityData
        {
            asset_id = assetId,
            initial_hole_appear_chance = 10,
            hole_chance_increase = 10,
            hole_discover_units = new List<string> { "UNI5", "UNI16" },
            total_hunt_to_fill_hole = 100,
            material_to_lure_unit = "MAT13",
            material_to_repair_hole = "MAT10",
            hole_discover_message_id = "HRM3",
            next_unit_layer_message_id = "HRM4",
            layer_unit_clear_message_id = "HRM5",
            fully_repair_message_id = "HRM6",
            unit_to_boost_fill_hole = new List<WoodCabinActivityData.RepairHoleUnit>
            {
                new WoodCabinActivityData.RepairHoleUnit { unit = "UNI3", fill = 3 },
                new WoodCabinActivityData.RepairHoleUnit { unit = "UNI51", fill = 3 }
            },
            in_hole_unit_group = new List<WoodCabinActivityData.LayerUnit>
            {
                new WoodCabinActivityData.LayerUnit
                {
                    appear_poll = 1,
                    layer_1_units = new WoodCabinActivityData.UnitQuantity
                    {
                        quantity = 16,
                        units = new List<string> { "UNI21", "UNI27", "UNI37" }
                    },
                    layer_2_units = new WoodCabinActivityData.UnitQuantity
                    {
                        quantity = 10,
                        units = new List<string> { "UNI28", "UNI29", "UNI35" }
                    },
                    layer_3_units = new WoodCabinActivityData.UnitQuantity
                    {
                        quantity = 6,
                        units = new List<string> { "UNI30", "UNI31", "UNI36" }
                    },
                    layer_4_units = new WoodCabinActivityData.UnitQuantity
                    {
                        quantity = 3,
                        units = new List<string> { "UNI32", "UNI33" }
                    },
                    layer_5_units = new WoodCabinActivityData.UnitQuantity
                    {
                        quantity = 1,
                        units = new List<string> { "UNI34" }
                    }
                },
                new WoodCabinActivityData.LayerUnit
                {
                    appear_poll = 1,
                    layer_1_units = new WoodCabinActivityData.UnitQuantity
                    {
                        quantity = 16,
                        units = new List<string> { "UNI40", "UNI42" }
                    },
                    layer_2_units = new WoodCabinActivityData.UnitQuantity
                    {
                        quantity = 10,
                        units = new List<string> { "UNI41", "UNI45", "UNI49" }
                    },
                    layer_3_units = new WoodCabinActivityData.UnitQuantity
                    {
                        quantity = 6,
                        units = new List<string> { "UNI44", "UNI46" }
                    },
                    layer_4_units = new WoodCabinActivityData.UnitQuantity
                    {
                        quantity = 3,
                        units = new List<string> { "UNI43", "UNI47" }
                    },
                    layer_5_units = new WoodCabinActivityData.UnitQuantity
                    {
                        quantity = 1,
                        units = new List<string> { "UNI48" }
                    }
                }
            },
            to_new_location = new NewLocation
            {
                location_id = "LOC2",
                material_to_unlock_location = "MAT22",
                min_activity_clear_count_to_unlock = 2
            }
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Activity";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{ActivityDataFilename.woodCabin}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (activity));
        dataPath = $"{Application.streamingAssetsPath}/Data/Activity/Wood Cabin Activity Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (activity, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{ActivityDataFilename.woodCabin}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
