using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons_Scripts : MonoBehaviour
{

    public Button exitGame;
    public Button loadlevel;
    public Button loadleve2;
    public Button loadleve3;
    public Button credits;


    public void LoadLevel1()
    {
        //Additive used to load screen over main menu scene
        Debug.Log("Attempting to load level 1");
        SceneManager.LoadScene("Level1", LoadSceneMode.Additive);
    }
    public void LoadLevel2()
    {
        Debug.Log("Attempting to load level 2");
        SceneManager.LoadScene("Level2", LoadSceneMode.Additive);
    }
    public void LoadLevel3()
    {
        Debug.Log("Attempting to load level 3");
        SceneManager.LoadScene("Level3", LoadSceneMode.Additive);
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game");
        Application.Quit();
    }
}