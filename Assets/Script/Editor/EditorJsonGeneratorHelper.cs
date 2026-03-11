using Newtonsoft.Json;
using ProjectPestHuntData;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using ZeroFormatter;

public static class EditorJsonGeneratorHelper
{
    
    public static void GeneratePanelLanguageData<T> (string filename) where T : BaseData
    {
        string csvFile = $"{filename.Split (".")[0]}.csv";
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

        string[] content = File.ReadAllText (csvPath).Split ('\n'); ;
        StringBuilder json = new StringBuilder ("{");

        for (int i = 1; i < content.Length; i++)
        {
            string[] data = content[i].Split ('|');
            if (data.Length < 2)
                continue;

            json.Append ($"\n  \"{data[0].Trim ()}\": \"{data[1].Trim ()}\",");
        }
        json.Remove (json.Length - 1, 1);
        json.Append ("\n}");

        T language = JsonConvert.DeserializeObject<T> (json.ToString ());

        string dataPath = $"{Application.streamingAssetsPath}/Language/Panel";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{filename}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (language));
        Debug.Log ($"<color=green>Panel language file \"{filename}\" has generated successful.</color>");
        Debug.Log (dataPath);

        dataPath = $"{Application.streamingAssetsPath}/Language/Panel/{filename.Split (".")[0]}.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (language, Formatting.Indented));
    }

    public static void GenerateAssetLanguageData (string csvFileName, string languageFileName)
    {
        string csvFile = $"{csvFileName}.csv";
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

        AssetLanguageList languages = new AssetLanguageList { language = new List<BaseLanguage> () };
        string[] content = File.ReadAllText (csvPath).Split ('\n');
        for (int i = 1; i < content.Length; i++)
        {
            string[] data = content[i].Trim ().Split ('|');
            if (data.Length < 2)
                continue;

            languages.language.Add (new BaseLanguage
            {
                asset_id = data[0],
                language = data[1]
            });
        }

        string dataPath = $"{Application.streamingAssetsPath}/Language/Asset";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{languageFileName}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (languages));
        Debug.Log ($"<color=green>Asset language file \"{languageFileName}\" has generated successful.</color>");
        Debug.Log (dataPath);

        dataPath = $"{Application.streamingAssetsPath}/Language/Asset/{languageFileName.Split (".")[0]}.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (languages, Formatting.Indented));
    }

    public static bool CheckAssetExist<T> (string assetId, IList<T> assetList) where T : BaseData
    {
        foreach (var asset in assetList)
        {
            if (string.Compare (asset.asset_id, assetId, true) == 0)
                return true;
        }
        return false;
    }
    public static bool CheckAssetExist (string assetId, IList<string> assetList)
    {
        foreach (var asset in assetList)
        {
            if (string.Compare (asset, assetId, true) == 0)
                return true;
        }
        return false;
    }
}
