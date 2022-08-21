using System.IO;
using UnityEngine;

public class Loader<T> where T : ISavable 
{
    public T Load(T data)
    {
        return  JsonUtility.FromJson<T>(File.ReadAllText($"{Application.streamingAssetsPath}/{data}.json")); 
    }
}
