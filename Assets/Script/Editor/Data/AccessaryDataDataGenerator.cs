using Newtonsoft.Json;
using ProgrammingConcept;
using ProjectPestHuntData;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class AccessoryDataJsonGenerator
{

    [MenuItem ("Data Generator/Data/Accessory")]
    static void GenerateJsonFromData ()
    {
        string csvFile = "Accessory Data.csv";
        string[] subPath = Application.dataPath.Split ('/');
        string csvPath = "";
        for (int i = 0; i < subPath.Length - 1; i++)
            csvPath += $"{subPath[i]}/";
        csvPath += $"csv/{csvFile}";

        if (!File.Exists (csvPath))
        {
            Debug.LogError ($"{csvPath} doesn't exist");
            return;
        }

        string dataPath = $"{Application.streamingAssetsPath}/Data/Asset";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        string[] content = File.ReadAllText (csvPath).Split ('\n');
        AssetDataList<AccessoryData> dataList = new AssetDataList<AccessoryData> { data = new List<AccessoryData> () };
        for (int i = 1; i < content.Length; i++)
        {
            string[] data = content[i].Trim ().Split ('|');
            if (data.Length < 6)
                continue;

            IList<MaterialData.CraftMaterial> materialList = new List<MaterialData.CraftMaterial> ();
            if (!string.IsNullOrEmpty (data[9]))
            {
                string[] materialData = data[9].Split ('&');
                for (int j = 0; j < materialData.Length; j++)
                {
                    string[] material = materialData[j].Split ('=');
                    if (material.Length < 2)
                    {
                        Debug.LogError ($"Failed to read {materialData[j]}");
                        break;
                    } else
                    {
                        materialList.Add (new MaterialData.CraftMaterial
                        {
                            material_id = material[0],
                            quantity = Parse.ToInt (material[1])
                        });
                    }
                }
            }

            IList<string> effects = new List<string> ();
            string[] effectData = data[10].Split (",");
            foreach (var effect in effectData)
            {
                if (!string.IsNullOrEmpty (effect))
                {
                    if (!EditorJsonGeneratorHelper.CheckAssetExist (effect, effects))
                        effects.Add (effect);
                }
            }

            AccessoryData Accessory = new AccessoryData
            {
                asset_id = data[0],
                reward_type = (Reward_Type)Parse.ToInt (data[2]),
                rarity = Parse.ToUshort (data[3]),
                cost = Parse.ToInt (data[4]),
                quantity = Parse.ToInt (data[5]),
                unlock_rank = Parse.ToByte (data[6]),
                get_at = data[7],
                base_craft_accessory_id = data[8],
                craft_materials = materialList,
                effect_id = effects,
                portrait_id = data[11],
                thumbnail_id = data[12],
                silhouette_id = data[13]
            };
            dataList.data.Add (Accessory);
        }

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{AssetDataFilename.accessory}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (dataList));
        dataPath = $"{Application.streamingAssetsPath}/Data/Asset/AccessoryData.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (dataList, Formatting.Indented));

        Debug.Log ($"<color=green>Asset data file \"{AssetDataFilename.accessory}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
