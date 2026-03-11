using Newtonsoft.Json;
using ProgrammingConcept;
using ProjectPestHuntData;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class WeaponDataDataGenerator
{

    [MenuItem ("Data Generator/Data/Weapon")]
    static void GenerateJsonFromData ()
    {
        string csvFile = "Weapon Data.csv";
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
        AssetDataList<WeaponData> dataList = new AssetDataList<WeaponData> { data = new List<WeaponData> () };
        for (int i = 1; i < content.Length; i++)
        {
            string[] data = content[i].Trim ().Split ('|');
            if (data.Length < 6)
                continue;

            IList<MaterialData.CraftMaterial> materialList = new List<MaterialData.CraftMaterial> ();
            if (!string.IsNullOrEmpty (data[10]))
            {
                string[] materialData = data[10].Split ('&');
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

            IList<string> ammos = new List<string> ();
            string[] ammoData = data[11].Split (",");
            foreach (var ammo in ammoData)
            {
                if (!string.IsNullOrEmpty (ammo))
                {
                    if (!EditorJsonGeneratorHelper.CheckAssetExist (ammo, ammos))
                        ammos.Add (ammo);
                }
            }

            WeaponData weapon = new WeaponData
            {
                asset_id = data[0],
                reward_type = (Reward_Type)Parse.ToInt (data[2]),
                elemental = data[3],
                strength = Parse.ToInt (data[4]),
                cost = Parse.ToInt (data[5]),
                quantity = Parse.ToInt (data[6]),
                unlock_rank = Parse.ToByte (data[7]),
                get_at = data[8],
                base_craft_weapon_id = data[9],
                craft_materials = materialList,
                ammo_id = ammos,
                portrait_id = data[12],
                thumbnail_id = data[13],
                silhouette_id = data[14]
            };
            dataList.data.Add (weapon);
        }

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{AssetDataFilename.weapon}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (dataList));
        dataPath = $"{Application.streamingAssetsPath}/Data/Asset/WeaponData.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (dataList, Formatting.Indented));

        Debug.Log ($"<color=green>Asset data file \"{AssetDataFilename.weapon}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
