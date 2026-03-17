using Newtonsoft.Json;
using ProgrammingConcept;
using ProjectPestHuntData;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class RankDataDataGenerator
{

    [MenuItem ("Data Generator/Data/Rank")]
    static void GenerateDataFromData ()
    {
        string csvFile = "Rank Data.csv";
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
        AssetDataList<RankData> dataList = new AssetDataList<RankData> { data = new List<RankData> () };
        for (int i = 1; i < content.Length; i++)
        {
            string[] data = content[i].Trim ().Split ('|');
            if (data.Length < 3)
                continue;

            RankData rank = new RankData
            {
                asset_id = data[0],
                level = Parse.ToInt (data[1]),
                rank_up_experience = Parse.ToInt (data[3]),
                accumulate_experience = Parse.ToInt (data[4])
            };
            dataList.data.Add (rank);
        }

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{AssetDataFilename.rank}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (dataList));
        dataPath = $"{Application.streamingAssetsPath}/Data/Asset/RankData.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (dataList, Formatting.Indented));

        Debug.Log ($"<color=green>Asset data file \"{AssetDataFilename.rank}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
