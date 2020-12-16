using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ChangeLevelBackground : MonoBehaviour
{
    public Sprite[] backGroundSprites;
    public GameObject backGround;
    public  Dropdown dropdown;
    private void Start()
    {
        Debug.Log("START LEVEL BACKGROUND");
        if (!PlayerPrefs.HasKey("openLevelBackground"))
        {
            PlayerPrefs.SetInt("openLevelBackground", 0);
        }
        if (!PlayerPrefs.HasKey("currentLevelBackground"))
        {
            PlayerPrefs.SetInt("currentLevelBackground", 0);
        }
        backGround.GetComponent<SpriteRenderer>().sprite = backGroundSprites[PlayerPrefs.GetInt("currentLevelBackground")];
        dropdown.value=PlayerPrefs.GetInt("currentLevelBackground");
    }
    public void SetBackGround(int value)
    {
        if (value == 0 && value <= PlayerPrefs.GetInt("openLevelBackground"))
        { 
            Debug.Log("SET LEVEL BACKGROUND:COSMO");
            dropdown.GetComponent<Image>().sprite = backGroundSprites[0];
            backGround.GetComponent<SpriteRenderer>().sprite = backGroundSprites[0];
            PlayerPrefs.SetInt("currentLevelBackground", 0);
        }
        if (value == 1 )
        {
            if (value <= PlayerPrefs.GetInt("openLevelBackground"))
            {
                Debug.Log("SET LEVEL BACKGROUND:GALAXY");
                dropdown.GetComponent<Image>().sprite = backGroundSprites[1];
                backGround.GetComponent<SpriteRenderer>().sprite = backGroundSprites[1];
                PlayerPrefs.SetInt("currentLevelBackground", 1);
            }
            else 
            {
                Debug.Log("GO TO BUY SECOND LEVEL BACKGROUND");
                SceneManager.LoadScene("BuyLevelBackGround");
            }
        }
       
        if (value == 2)
        {
            if (value <= PlayerPrefs.GetInt("openLevelBackground"))
            {
                Debug.Log("SET LEVEL BACKGROUND:ICE");
                dropdown.GetComponent<Image>().sprite = backGroundSprites[2];
                backGround.GetComponent<SpriteRenderer>().sprite = backGroundSprites[2];
                PlayerPrefs.SetInt("currentLevelBackground", 2);
            }
            else
            {
                if (PlayerPrefs.GetInt("openLevelBackground") != 1)
                {
                    dropdown.value = PlayerPrefs.GetInt("currentLevelBackground");
                }
                else
                {
                    Debug.Log("GO TO BUY THIRD LEVEL BACKGROUND");
                    SceneManager.LoadScene("BuyLevelBackGround");
                }
            }
        }
    }
}
