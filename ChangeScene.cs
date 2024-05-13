using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class ChangeScene : MonoBehaviour
{
    public int SceneIdx;
    public int ActualSceneIdx;

    // Trigger script for moving between scenes
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            GameObject.Find("SaveManager").GetComponent<JSONsave>().StoreWin();
            SceneManager.LoadScene(SceneIdx);
        }
    }
}
