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

    public Button menuButton;

    public void LoadLevel1()
    {
        Debug.Log("Attempting to load level 1");
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);

    }
    public void LoadLevel2()
    {
        Debug.Log("Attempting to load level 2");
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    }
    public void LoadCredits()
    {
        Debug.Log("Attempting to load Credits");
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }

    public void LoadLevel3()
    {
        Debug.Log("Attempting to load level 3");
        SceneManager.LoadScene("Level3", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game");
        Application.Quit();
    }

    public void MenuReturn()
    {
        Debug.Log("Returning to main menu");
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("MainMenu");
        SceneManager.UnloadSceneAsync(scene.name);
    }

}