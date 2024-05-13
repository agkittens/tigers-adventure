using UnityEngine;
using UnityEngine.SceneManagement;

using System.Collections;
using System.IO;
using System;


public class JSONsave : MonoBehaviour
{
    public GameObject cat;
    public GameObject portal;

    public int[] win;

    public static JSONsave instance { get; private set; }
    private JSONdata d;
    bool loading;

    // Check for data manager object
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;

    }

    // Handles updating scene data for both save file and gameplay
    private void OnSceneLoaded(Scene name, LoadSceneMode mode)
    {
        cat = GameObject.Find("Player");
        portal = GameObject.Find("Portal");

        if (loading)
        {
            cat.transform.SetPositionAndRotation(d.position, d.rotation);
            cat.GetComponent<win_controller>().LoadData(d.win);
            loading = false;
        }
        else
        {
            cat.GetComponent<win_controller>().LoadData(win);

        }

    }

    // Stores win status between scenes
    public void StoreWin()
    {
        win = cat.GetComponent<win_controller>().Status();
    }

    // Saves game state to json
    public void Save()
	{
        Transform t = cat.transform;
        int[] win = cat.GetComponent<win_controller>().Status();
        int index = portal.GetComponent<ChangeScene>().SceneIdx;
        index = index == 1 ? 0 : 1;
        JSONdata data = new JSONdata(t.position, t.rotation, index, win);


        string path = Application.persistentDataPath + "/save.json";
		string json = JsonUtility.ToJson(data);
		using StreamWriter writer = new StreamWriter(path);
		writer.Write(json);
        Debug.Log(json);
    }

    // Loads game from json
	public void Load()
	{
        string path = Application.persistentDataPath + "/save.json";
		using StreamReader reader = new StreamReader(path);
		string json = reader.ReadToEnd();
		d = JsonUtility.FromJson<JSONdata>(json);
        loading = true;
        SceneManager.LoadScene(d.scene);
    }

 

    private void OnApplicationQuit()
    {
        Save();
    }
}

