using Newtonsoft.Json;
using ProjectPestHuntData;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class RegionDataDataGenerator
{

    [MenuItem ("Data Generator/Data/Region")]
    static void GenerateJsonFromData ()
    {
        string csvFile = "Region Data.csv";
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
        AssetDataList<RegionData> dataList = new AssetDataList<RegionData> { data = new List<RegionData> () };
        for (int i = 1; i < content.Length; i++)
        {
            string[] data = content[i].Trim ().Split ('|');
            if (data.Length < 4)
                continue;

            IList<string> locations = new List<string> ();
            IList<string> units = new List<string> ();
            IList<RegionData.RewardPoll> rewards = new List<RegionData.RewardPoll> ();

            if (!string.IsNullOrEmpty (data[2]))
            {
                string[] locationData = data[2].Split (",");
                foreach (var location in locationData)
                {
                    if (!string.IsNullOrEmpty (location))
                    {
                        if (!EditorJsonGeneratorHelper.CheckAssetExist (location, locations))
                            locations.Add (location);
                    }
                }
            }

            if (!string.IsNullOrEmpty (data[4]))
            {
                string[] unitData = data[4].Split (",");
                foreach (var unit in unitData)
                {
                    if (!string.IsNullOrEmpty (unit))
                    {
                        if (!EditorJsonGeneratorHelper.CheckAssetExist (unit, units))
                            units.Add (unit);
                    }
                }
            }

            if (!string.IsNullOrEmpty (data[5]))
            {
                string[] rewardData = data[5].Split ("&");
                foreach (var reward in rewardData)
                {
                    string[] r = reward.Split ("=");
                    if (r.Length < 2)
                        continue;

                    if (!EditorJsonGeneratorHelper.CheckAssetExist (r[0], rewards))
                    {
                        if (int.TryParse (r[1], out int value))
                        {
                            rewards.Add (new RegionData.RewardPoll
                            {
                                asset_id = r[0],
                                poll = value
                            });
                        }
                    }
                }
            }

            RegionData region = new RegionData
            {
                asset_id = data[0],
                fairy_appear_id = data[3],
                location_id = locations,
                unit_id = units,
                reward_polls = rewards
            };
            dataList.data.Add (region);
        }

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{AssetDataFilename.region}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (dataList));
        dataPath = $"{Application.streamingAssetsPath}/Data/Asset/RegionData.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (dataList, Formatting.Indented));

        Debug.Log ($"<color=green>Asset data file \"{AssetDataFilename.region}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
