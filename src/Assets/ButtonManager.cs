using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public void LoadLevel(int numLvl)
    {
        if (numLvl == LevelManager.countUnlockedLevel+1)
        {
            SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings-2);
        }
        else
        {
            SceneManager.LoadScene(numLvl);
        }
    }
    public void WatchAd()
    {
        Debug.Log("WATCH Ad");
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings-1);
    }
    public void LoadMenu()
    {
        Debug.Log("To MENU");
        SceneManager.LoadScene(0);
    }
    public void LoadMenuAfterAd()
    {
        Debug.Log("To MENU after Ad");
        PlayerPrefs.SetInt("coins",PlayerPrefs.GetInt("coins") + 15);
        PlayerPrefs.SetInt("Levels", LevelManager.countUnlockedLevel + 1);
        SceneManager.LoadScene(0);
    }
    public void QuitTheGame()
    {
        Debug.Log("QUIT THE GAME");
        PlayerPrefs.DeleteAll();
        Application.Quit();    // закрыть приложение
       
    }
}
