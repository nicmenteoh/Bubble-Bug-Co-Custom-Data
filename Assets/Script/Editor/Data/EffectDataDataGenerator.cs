using Newtonsoft.Json;
using ProgrammingConcept;
using ProjectPestHuntData;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class EffectDataDataGenerator
{

    [MenuItem ("Data Generator/Data/Effect")]
    static void GenerateJsonFromData ()
    {
        string csvFile = "Effect Data.csv";
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
        AssetDataList<EffectData> dataList = new AssetDataList<EffectData> { data = new List<EffectData> () };
        for (int i = 1; i < content.Length; i++)
        {
            string[] data = content[i].Trim ().Split ('|');
            if (data.Length < 3)
                continue;

            IList<int> values = new List<int> ();

            string[] valueData = data[3].Split (",");
            foreach (var value in valueData)
            {
                if (!string.IsNullOrEmpty (value))
                {
                    values.Add (Parse.ToInt (value));
                }
            }

            EffectData effect = new EffectData
            {
                asset_id = data[0],
                effect = (Accessory_Effect)Parse.ToInt (data[2]),
                values = values
            };
            dataList.data.Add (effect);
        }

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{AssetDataFilename.effect}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (dataList));
        dataPath = $"{Application.streamingAssetsPath}/Data/Asset/EffectData.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (dataList, Formatting.Indented));

        Debug.Log ($"<color=green>Asset data file \"{AssetDataFilename.effect}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
