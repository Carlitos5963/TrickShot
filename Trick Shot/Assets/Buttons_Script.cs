using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExtrasButtons : MonoBehaviour {

    public Button exitGame;
    public Button loadlevel;
    public Button loadleve2;
    public Button loadleve3;
    public Button credits;

    public string Level1;
    public string Level2;
    public string Level3;


    public void LoadLevel1()
    {
        Debug.Log("Attempting to load level 1");
        SceneManager.LoadScene(Level1);
    }
    public void LoadLevel2()
    {
        Debug.Log("Attempting to load level 2");
        SceneManager.LoadScene(Level2);
    }
    public void LoadLevel3()
    {
        Debug.Log("Attempting to load level 3");
        SceneManager.LoadScene(Level3);
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game");
        Application.Quit();
    }
}
