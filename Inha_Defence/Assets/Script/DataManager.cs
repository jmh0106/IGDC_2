using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class GameData
{
    public int clearStage = 1;
    public string name = "정민호";
}

public class DataManager : MonoBehaviour
{
    private void Awake()
    {
        var game1Data = new GameData();
        var jsonData = ObjectToJson(game1Data);
        CreateJsonFile($"{Application.dataPath}/Resources/Data/GameData", "Game1Data", jsonData);
    }

    private string ObjectToJson(object obj)
    {
        
        return JsonUtility.ToJson(obj);
    }

    private T JsonToObject<T>(string jsonData)
    {
        return JsonUtility.FromJson<T>(jsonData);
    }
    
    private void CreateJsonFile(string createPath, string fileName, string jsonData)
    {
        var fileStream = new FileStream($"{createPath}/{fileName}.json", FileMode.Create);
        var data = Encoding.UTF8.GetBytes(jsonData);
        fileStream.Write(data, 0, data.Length);
        fileStream.Close();
    }

    private T LoadJsonFile<T>(string loadPath, string fileName)
    {
        var fileStream = new FileStream($"{loadPath}/{fileName}.json", FileMode.Open);
        var data = new byte[fileStream.Length];
        fileStream.Read(data, 0, data.Length);
        fileStream.Close();
        var jsonData = Encoding.UTF8.GetString(data);
        return JsonUtility.FromJson<T>(jsonData);
    }
}

