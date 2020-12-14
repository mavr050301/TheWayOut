using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeBackground : MonoBehaviour
{
    public Sprite[] backGroundSprites;
    public  Image backGround;
    public static Image backGroundSave;
    public Dropdown dropdown;
    public static Dropdown dropdownSave;
    public static int flag=0;
    private void Start()
    {
        if (flag == 0)
        {
            backGround.sprite = backGroundSprites[0];
            backGroundSave = backGround;
            dropdown.value=0;
            dropdownSave=dropdown;
            flag++;
        }
        else
        {
            backGround.sprite = backGroundSave.sprite;
            dropdown.value = dropdownSave.value;
        }
    }
    public void SetBackGround(int value)
    {
        if (value == 0)
        {
            dropdown.GetComponent<Image>().sprite = backGroundSprites[0];
          backGround.sprite = backGroundSprites[0];
        }
        if (value == 1)
        {
         dropdown.GetComponent<Image>().sprite= backGroundSprites[1];
            backGround.sprite = backGroundSprites[1];
        }
        if (value == 2)
        {
            dropdown.GetComponent<Image>().sprite = backGroundSprites[2];
            backGround.sprite = backGroundSprites[2];
        }
       // dropdown.options.Add(new Dropdown.OptionData() { text = "HELLO" });
        backGroundSave = backGround;
        dropdownSave = dropdown;
    }
 }
