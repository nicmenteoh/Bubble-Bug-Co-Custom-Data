using Newtonsoft.Json;
using ProgrammingConcept;
using ProjectPestHuntData;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class MaterialDataDataGenerator
{

    [MenuItem ("Data Generator/Data/Material")]
    static void GenerateJsonFromData ()
    {
        string csvFile = "Material Data.csv";
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
        AssetDataList<MaterialData> dataList = new AssetDataList<MaterialData> { data = new List<MaterialData> () };
        for (int i = 1; i < content.Length; i++)
        {
            string[] data = content[i].Trim ().Split ('|');
            if (data.Length < 3)
                continue;

            IList<MaterialData.CraftMaterial> materialList = new List<MaterialData.CraftMaterial> ();
            if (!string.IsNullOrEmpty (data[7]))
            {
                string[] materialData = data[7].Split ('&');
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

            MaterialData material = new MaterialData
            {
                asset_id = data[0],
                reward_type = (Reward_Type)Parse.ToInt (data[2]),
                cost = Parse.ToInt (data[3]),
                free_claim_poll = Parse.ToInt (data[4]),
                quantity = Parse.ToInt (data[5]),
                get_at = data[6],
                craft_materials = materialList, 
                portrait_id = data[0],
                thumbnail_id = data[0]
            };
            dataList.data.Add (material);
        }

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{AssetDataFilename.material}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (dataList));
        dataPath = $"{Application.streamingAssetsPath}/Data/Asset/MaterialData.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (dataList, Formatting.Indented));

        Debug.Log ($"<color=green>Asset data file \"{AssetDataFilename.material}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
