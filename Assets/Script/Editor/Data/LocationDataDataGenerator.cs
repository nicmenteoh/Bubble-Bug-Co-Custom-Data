using Newtonsoft.Json;
using ProjectPestHuntData;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class LocationDataDataGenerator
{

    [MenuItem ("Data Generator/Data/Location")]
    static void GenerateJsonFromData ()
    {
        string csvFile = "Location Data.csv";
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
        AssetDataList<LocationData> dataList = new AssetDataList<LocationData> { data = new List<LocationData> () };
        for (int i = 1; i < content.Length; i++)
        {
            string[] data = content[i].Trim ().Split ('|');
            if (data.Length < 6)
                continue;

            IList<string> units = new List<string> ();
            IList<RegionData.RewardPoll> rewards = new List<RegionData.RewardPoll> ();

            string[] unitData = data[2].Split (",");
            foreach (var unit in unitData)
            {
                if (!string.IsNullOrEmpty (unit))
                {
                    if (!EditorJsonGeneratorHelper.CheckAssetExist (unit, units))
                        units.Add (unit);
                }
            }

            string[] rewardData = data[3].Split ("&");
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

            LocationData location = new LocationData
            {
                asset_id = data[0],
                activity_id = data[4],
                intro_id = data[5],
                unit_id = units,
                reward_polls = rewards,
                portrait_id = data[6],
                thumbnail_id = data[7]
            };
            dataList.data.Add (location);
        }

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{AssetDataFilename.location}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (dataList));
        dataPath = $"{Application.streamingAssetsPath}/Data/Asset/LocationData.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (dataList, Formatting.Indented));

        Debug.Log ($"<color=green>Asset data file \"{AssetDataFilename.location}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
