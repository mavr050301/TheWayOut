using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeLevelBackground : MonoBehaviour
{
    public Sprite[] backGroundSprites;
    public GameObject backGround;
    public static int number,openLevels=1;
    public  Dropdown dropdown;
    public static Dropdown dropdownSave;
    public static int flag = 0;
    private void Start()
    {
        if (flag == 0)
        {
            backGround.GetComponent<SpriteRenderer>().sprite = backGroundSprites[0];
            dropdown.value = 0;
            dropdownSave = dropdown;
            flag++;
            
        }
      else
      {
            backGround.GetComponent<SpriteRenderer>().sprite = backGroundSprites[number];
          dropdown.value =dropdownSave.value ;
       }
    }
    public void SetBackGround(int value)
    {
        if (value == 0 && value < openLevels)
        {
            dropdown.GetComponent<Image>().sprite = backGroundSprites[0];
            backGround.GetComponent<SpriteRenderer>().sprite = backGroundSprites[0];
            number = 0;
            Debug.Log("SET FIRST");
        }
        if (value == 1 && value < openLevels)
        {
            dropdown.GetComponent<Image>().sprite = backGroundSprites[1];
            backGround.GetComponent<SpriteRenderer>().sprite = backGroundSprites[1];
            number = 1;
            Debug.Log("SET SECOND");
        }
        if (value == 2 && value < openLevels)
        {
            dropdown.GetComponent<Image>().sprite = backGroundSprites[2];
            backGround.GetComponent<SpriteRenderer>().sprite = backGroundSprites[2];
            number = 2;
            Debug.Log("SET THIRD");
        }
        //dropdown.options.Add(new Dropdown.OptionData() { text = "HELLO" });
        dropdownSave = dropdown;

    }
}
