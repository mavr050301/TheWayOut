using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public void LoadLevel(int numLvl)
    {
        if (numLvl == LevelManager.countUnlockedLevel+1)
        {
            SceneManager.LoadScene("BuyLevel");
        }
        else
        {
            SceneManager.LoadScene(numLvl);
        }
    }
    public void WatchAd()
    {
        Debug.Log("WATCH Ad");
        SceneManager.LoadScene("Ad");
    }
    public void LoadMenuAfterAd()
    {
        Debug.Log("To MENU after Ad");
        PlayerPrefs.SetInt("coins",PlayerPrefs.GetInt("coins") + 20);
        SceneManager.LoadScene("Menu");
    }
    public void BuyLevelBackground()
    {
        if (PlayerPrefs.GetInt("coins") >= 10)
        {
            Debug.Log("Buy Level Background");
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 10);
            PlayerPrefs.SetInt("openLevelBackground", PlayerPrefs.GetInt("openLevelBackground") + 1);
            PlayerPrefs.SetInt("currentLevelBackground", PlayerPrefs.GetInt("currentLevelBackground") + 1);
            SceneManager.LoadScene("Menu");
        }
        else
        {
            SceneManager.LoadScene("WatchAds");
        }
    }
    public void BuyLevel()
    {
        if (PlayerPrefs.GetInt("coins") >= 20)
        {
            Debug.Log("Buy Level");
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 20);
            PlayerPrefs.SetInt("Levels", LevelManager.countUnlockedLevel + 1);
            SceneManager.LoadScene("Menu");
        }
        else
        {
            SceneManager.LoadScene("WatchAds");
        }
    }
    public void BuyHelp()
    {
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 5);
        PlayerPrefs.SetInt(PlayerPrefs.GetInt("currentlevelHelp").ToString(), 1);
        SceneManager.LoadScene(System.Convert.ToInt32(PlayerPrefs.GetInt("currentlevelHelp")));
    }
    public void LoadMenu()
    {
        Debug.Log("To MENU");
        SceneManager.LoadScene("Menu");
    }
    public void Store()
    {
        Debug.Log("To STORE");
        SceneManager.LoadScene("Store");
    }
    public void FinalStore()
    {
        Debug.Log("To FINAL STORE");
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 100);
        SceneManager.LoadScene("Menu");
    }
    public void QuitTheGame()
    {
        Debug.Log("QUIT THE GAME");
        Application.Quit(); 
    }
}
