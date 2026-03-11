using Newtonsoft.Json;
using ProgrammingConcept;
using ProjectPestHuntData;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class FairyDataDataGenerator
{

    [MenuItem ("Data Generator/Data/Fairy")]
    static void GenerateJsonFromData ()
    {
        string csvFile = "Fairy Data.csv";
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
        AssetDataList<FairyData> dataList = new AssetDataList<FairyData> { data = new List<FairyData> () };
        for (int i = 1; i < content.Length; i++)
        {
            string[] data = content[i].Trim ().Split ('|');
            if (data.Length < 6)
                continue;

            IList<string> effects = new List<string> ();
            string[] effectData = data[8].Split (",");
            foreach (var effect in effectData)
            {
                if (!string.IsNullOrEmpty (effect))
                {
                    if (!EditorJsonGeneratorHelper.CheckAssetExist (effect, effects))
                        effects.Add (effect);
                }
            }

            IList<MaterialData.CraftMaterial> materialList = new List<MaterialData.CraftMaterial> ();
            if (!string.IsNullOrEmpty (data[11]))
            {
                string[] materialData = data[11].Split ('&');
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

            FairyData fairy = new FairyData
            {
                asset_id = data[0],
                reward_type = (Reward_Type)Parse.ToInt (data[2]),
                rarity = Parse.ToByte (data[3]),
                base_strength = Parse.ToInt (data[4]),
                strength_per_level = Parse.ToInt (data[5]),
                luck = Parse.ToByte (data[6]),
                food_id = data[7],
                effect_id = effects,
                awaken_to = data[9],
                duplicate_drop = data[10],
                awaken_material = materialList,
                portrait_id = data[12],
                thumbnail_id = data[13],
                silhouette_id = data[14]
            };
            dataList.data.Add (fairy);
        }

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{AssetDataFilename.fairy}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (dataList));
        dataPath = $"{Application.streamingAssetsPath}/Data/Asset/FairyData.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (dataList, Formatting.Indented));

        Debug.Log ($"<color=green>Asset data file \"{AssetDataFilename.fairy}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
