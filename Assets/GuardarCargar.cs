using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class GuardarCargar
{
    public static void SaveData<T>(T data, string path, string fileName)
    {
        string fullpath = Application.persistentDataPath + "/" + path + "/";
        bool checkFolderExit = Directory.Exists(fullpath);
        if (checkFolderExit==false)
        {
            Directory.CreateDirectory(fullpath);
        }
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(fullpath + fileName + ".json", json);
        Debug.Log("informacion guardad " + fullpath);
    }
    public static T LoadData <T>(string path, string filename)
    {
        string fullpath = Application.persistentDataPath + "/" + path + "/" +filename+".json";
        if (File.Exists(fullpath))
        {
            string textJson = File.ReadAllText(fullpath);
            var obj = JsonUtility.FromJson<T>(textJson);
            return obj;
        }
        else
        {
            Debug.Log("No Hay que cargar");
            return default;
        }
    }


}
