using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeMenuBackground : MonoBehaviour
{
    public Sprite[] backGroundSprites;
    public  Image backGround;
    public Dropdown dropdown;
    private void Start()
    {
        Debug.Log("START MENU BACKGROUND");
        if (!PlayerPrefs.HasKey("CurrentMenuBackground"))
        {
            PlayerPrefs.SetInt("CurrentMenuBackground", 0);
        }
        backGround.sprite = backGroundSprites[PlayerPrefs.GetInt("currentMenuBackground")];
        dropdown.value= PlayerPrefs.GetInt("currentMenuBackground");   
    }
    public void SetBackGround(int value)
    {
        if (value == 0)
        {
            Debug.Log("SET MENU BACKGROUND:COSMO");
            dropdown.GetComponent<Image>().sprite = backGroundSprites[0];
            backGround.sprite = backGroundSprites[0];
            PlayerPrefs.SetInt("currentMenuBackground", 0);
        }
        if (value == 1)
        {
            Debug.Log("SET MENU BACKGROUND:WOOD");
            dropdown.GetComponent<Image>().sprite= backGroundSprites[1];
            backGround.sprite = backGroundSprites[1];
            PlayerPrefs.SetInt("currentMenuBackground", 1);
        }
        if (value == 2)
        {
            Debug.Log("SET MENU BACKGROUND:GRADIENT");
            dropdown.GetComponent<Image>().sprite = backGroundSprites[2];
            backGround.sprite = backGroundSprites[2];
            PlayerPrefs.SetInt("currentMenuBackground", 2);
        }
    }
 }
