using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DataManager : MonoBehaviour
{
    public static bool SaveGame(string saveName, object gameData){
        BinaryFormatter formatter = GetBinaryFormatter();

        if(!Directory.Exists(Application.persistentDataPath + "/saves")){
            Directory.CreateDirectory(Application.persistentDataPath + "/saves");
        }
        
        string path = Application.persistentDataPath + "/saves/" + saveName + ".save";
    
        FileStream file = File.Create(path);
        formatter.Serialize(file, gameData);
        file.Close();

        return true;
    }


    public static object Load(string path){
        if(!File.Exists(path)){
            return null;
        }

        BinaryFormatter formatter = GetBinaryFormatter();
        FileStream file = File.Open(path, FileMode.Open);

        try{
            object save = formatter.Deserialize(file);
            file.Close();
            return save;
        }

        catch{
            Debug.LogErrorFormat("Failed to load");
            file.Close();
            return null;
        }
    }

    public static BinaryFormatter GetBinaryFormatter(){
        BinaryFormatter formatter = new BinaryFormatter();
        
        return formatter;
    }
}
