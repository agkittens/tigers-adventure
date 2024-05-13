using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Quits game
    public void ExitButton(){
        Application.Quit();
        Debug.Log("Game closed");
    }

    // Starts new game
    public void NewGameButton(){
        SceneManager.LoadScene(0);
    }

}
