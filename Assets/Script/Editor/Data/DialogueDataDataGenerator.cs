using Newtonsoft.Json;
using ProjectPestHuntData;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class DialogueDataDataGenerator
{

    [MenuItem ("Data Generator/Data/Dialogue")]
    static void GenerateJsonFromData ()
    {
        string csvFile = "Dialogue Data.csv";
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
        AssetDataList<DialogueData> dataList = new AssetDataList<DialogueData> { data = new List<DialogueData> () };
        for (int i = 1; i < content.Length; i++)
        {
            string[] data = content[i].Trim ().Split ('|');
            if (data.Length < 3)
                continue;

            string[] charPos = data[3].Split (",");
            string[] diaPos = data[4].Split (",");
            DialogueData.Dialogue dialogue = new DialogueData.Dialogue
            {
                character_id = data[2],
                dialogue = data[5],
                character_position = new FloatXY
                {
                    x = float.Parse (charPos[0]),
                    y = float.Parse (charPos[1])
                },
                dialogue_position = new FloatXY
                {
                    x = float.Parse (diaPos[0]),
                    y = float.Parse (diaPos[1])
                }
            };

            bool inserted = false;
            foreach (var intro in dataList.data)
            {
                if (string.Compare (intro.asset_id, data[0], true) == 0)
                {
                    bool exist = false;
                    int index = int.Parse (data[1]);
                    foreach (var segment in intro.intro)
                    {
                        if (segment.segment == index)
                        {
                            segment.dialogues.Add (dialogue);

                            exist = true;
                            break;
                        }
                    }
                    if (!exist)
                    {
                        intro.intro.Add (new DialogueData.Segment
                        {
                            segment = index,
                            dialogues = new List<DialogueData.Dialogue> { dialogue }
                        });
                    }

                    inserted = true;
                    break;
                }
            }
            if (!inserted)
            {
                dataList.data.Add (new DialogueData
                {
                    asset_id = data[0],
                    intro = new List<DialogueData.Segment>
                    {
                        new DialogueData.Segment
                        {
                            segment = int.Parse (data[1]),
                            dialogues = new List<DialogueData.Dialogue> { dialogue }
                        }
                    }
                });
            }
        }

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{AssetDataFilename.dialogue}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (dataList));
        dataPath = $"{Application.streamingAssetsPath}/Data/Asset/DialogueData.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (dataList, Formatting.Indented));

        Debug.Log ($"<color=green>Asset data file \"{AssetDataFilename.dialogue}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
