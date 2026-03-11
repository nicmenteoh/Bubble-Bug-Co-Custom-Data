using Newtonsoft.Json;
using ProgrammingConcept;
using ProjectPestHuntData;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class UnitDataDataGenerator
{

    [MenuItem ("Data Generator/Data/Unit")]
    static void GenerateJsonFromData ()
    {
        string csvFile = "Unit Data.csv";
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
        AssetDataList<UnitData> dataList = new AssetDataList<UnitData> { data = new List<UnitData> () };
        for (int i = 1; i < content.Length; i++)
        {
            string[] data = content[i].Trim ().Split ('|');
            if (data.Length < 3)
                continue;

            IList<UnitData.FlavourData> flavourList = new List<UnitData.FlavourData> ();
            if (!string.IsNullOrEmpty (data[9]))
            {
                string[] flavourData = data[9].Split ('&');
                for (int j = 0; j < flavourData.Length; j++)
                {
                    string[] flavour = flavourData[j].Split ('=');
                    if (flavour.Length < 2)
                    {
                        Debug.LogError ($"Failed to read {flavourData[j]}");
                    } else
                    {
                        flavourList.Add (new UnitData.FlavourData
                        {
                            flavour_id = flavour[0],
                            attract_poll = Parse.ToInt (flavour[1])
                        });
                    }
                }
            }

            IList<RegionData.RewardPoll> rewardList = new List<RegionData.RewardPoll> ();
            if (!string.IsNullOrEmpty (data[10]))
            {
                string[] rewardData = data[10].Split ('&');
                for (int j = 0; j < rewardData.Length; j++)
                {
                    string[] reward = rewardData[j].Split ('=');
                    if (reward.Length < 2)
                    {
                        Debug.LogError ($"Failed to read {rewardData[j]}");
                    } else
                    {
                        rewardList.Add (new RegionData.RewardPoll
                        {
                            asset_id = reward[0],
                            poll = Parse.ToInt (reward[1])
                        });
                    }
                }
            }

            UnitData unit = new UnitData
            {
                asset_id = data[0],
                family = data[2],
                elemental = data[3],
                strength = Parse.ToInt (data[4]),
                rage = (byte)Parse.ToInt (data[5]),
                size = Parse.ToInt (data[6]),
                coin = Parse.ToInt (data[7]),
                reputation = Parse.ToInt (data[8]),
                flavour_polls =flavourList,
                reward_polls = rewardList,
                portrait_id = data[11],
                thumbnail_id = data[12],
                silhouette_id = data[13]
            };
            dataList.data.Add (unit);
        }

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{AssetDataFilename.unit}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (dataList));
        dataPath = $"{Application.streamingAssetsPath}/Data/Asset/UnitData.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (dataList, Formatting.Indented));

        Debug.Log ($"<color=green>Asset data file \"{AssetDataFilename.unit}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
