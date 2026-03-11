using Newtonsoft.Json;
using ProgrammingConcept;
using ProjectPestHuntData;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class BaitDataDataGenerator
{

    [MenuItem ("Data Generator/Data/Bait")]
    static void GenerateJsonFromData ()
    {
        string csvFile = "Bait Data.csv";
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
        AssetDataList<BaitData> dataList = new AssetDataList<BaitData> { data = new List<BaitData> () };
        for (int i = 1; i < content.Length; i++)
        {
            string[] data = content[i].Trim ().Split ('|');
            if (data.Length < 3)
                continue;

            IList<MaterialData.CraftMaterial> materialList = new List<MaterialData.CraftMaterial> ();
            if (!string.IsNullOrEmpty (data[8]))
            {
                string[] materialData = data[8].Split ('&');
                for (int j = 0; j < materialData.Length; j++)
                {
                    string[] craftMaterial = materialData[j].Split ('=');
                    if (craftMaterial.Length < 2)
                    {
                        Debug.LogWarning ($"Failed to read {materialData[j]}");
                        break;
                    } else
                    {
                        materialList.Add (new MaterialData.CraftMaterial
                        {
                            material_id = craftMaterial[0],
                            quantity = Parse.ToInt (craftMaterial[1])
                        });
                    }
                }
            }

            IList<BaitData.AttractiveChance> familyList = new List<BaitData.AttractiveChance> ();
            if (!string.IsNullOrEmpty (data[9]))
            {
                string[] familyData = data[9].Split ('&');
                for (int j = 0; j < familyData.Length; j++)
                {
                    string[] flavour = familyData[j].Split ('=');
                    if (flavour.Length < 2)
                    {
                        Debug.LogError ($"Failed to read {familyData[j]}");
                        break;
                    } else
                    {
                        familyList.Add (new BaitData.AttractiveChance
                        {
                            family = flavour[0],
                            chance = Parse.ToInt (flavour[1])
                        });
                    }
                }
            }

            BaitData bait = new BaitData
            {
                asset_id = data[0],
                reward_type = (Reward_Type)Parse.ToInt (data[2]),
                available_chance = Parse.ToInt (data[3]),
                cost = Parse.ToInt (data[4]),
                free_claim_poll = Parse.ToInt (data[5]),
                quantity = Parse.ToInt (data[6]),
                get_at = data[7],
                craft_materials = materialList,
                family_attractive_chance = familyList,
                portrait_id = data[10],
                thumbnail_id = data[11]
            };
            dataList.data.Add (bait);
        }

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{AssetDataFilename.bait}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (dataList));
        dataPath = $"{Application.streamingAssetsPath}/Data/Asset/BaitData.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (dataList, Formatting.Indented));

        Debug.Log ($"<color=green>Asset data file \"{AssetDataFilename.bait}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
