using System;
using System.IO;
using UnityEditor;
using UnityEngine;

public class CaptureScreenshot
{
    [MenuItem ("Edit/Capture Screenshot")]
    public static void Screenshot ()
    {
        string path = $"{Environment.GetFolderPath (Environment.SpecialFolder.MyPictures)}/Unity Screenshot";
        if (!Directory.Exists (path))
            Directory.CreateDirectory (path);

        path += $"/Screenshot_{DateTime.Now:yyyy-m-d_H-mm-ss}.jpg";
        ScreenCapture.CaptureScreenshot ($"{path}");
        Debug.Log (path);
    }
}
