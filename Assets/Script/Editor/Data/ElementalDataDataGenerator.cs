using Newtonsoft.Json;
using ProgrammingConcept;
using ProjectPestHuntData;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class ElementalDataDataGenerator
{

    [MenuItem ("Data Generator/Data/Elemental")]
    static void GenerateJsonFromData ()
    {
        string csvFile = "Elemental Data.csv";
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
        AssetDataList<ElementalData> dataList = new AssetDataList<ElementalData> { data = new List<ElementalData> () };
        for (int i = 1; i < content.Length; i++)
        {
            string[] data = content[i].Trim ().Split ('|');
            if (data.Length < 3)
                continue;

            IList<ElementalData.Against> elementalList = new List<ElementalData.Against> ();
            string[] elementalData = data[2].Split ('&');
            for (int j = 0; j < elementalData.Length; j++)
            {
                string[] e = elementalData[j].Split ('=');
                if (e.Length < 2)
                {
                    Debug.LogError ($"Failed to read {elementalData[j]}");
                    break;
                } else
                {
                    elementalList.Add (new ElementalData.Against
                    {
                        asset_id = e[0],
                        value = Parse.ToInt (e[1], 1)
                    });
                }
            }

            ElementalData elemental = new ElementalData
            {
                asset_id = data[0],
                against = elementalList
            };
            dataList.data.Add (elemental);
        }

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{AssetDataFilename.elemental}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (dataList));
        dataPath = $"{Application.streamingAssetsPath}/Data/Asset/ElementalData.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (dataList, Formatting.Indented));

        Debug.Log ($"<color=green>Asset data file \"{AssetDataFilename.elemental}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
