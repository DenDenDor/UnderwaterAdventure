using System.IO;
using UnityEngine;

public class Saver<T> where T : ISavable 
{
   public void Save(T data)
   {
        File.WriteAllText($"{Application.streamingAssetsPath}/{data}.json", JsonUtility.ToJson(data));
   }
}
