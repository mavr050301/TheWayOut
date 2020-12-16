using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GetHelp : MonoBehaviour
{
    Color color;
    public GameObject Cube;
    public IEnumerator ChangeColor(GameObject Cube)
    {
        color = Cube.GetComponent<Renderer>().material.color;
        Debug.Log("START HELP");
            yield return new WaitForSeconds((float)0.3);
            Cube.GetComponent<Renderer>().material.color = Color.white;
            yield return new WaitForSeconds((float)0.3);
            Cube.GetComponent<Renderer>().material.color = color;
            yield return new WaitForSeconds((float)0.3);
            Cube.GetComponent<Renderer>().material.color = Color.white;
            yield return new WaitForSeconds((float)0.3);
            Cube.GetComponent<Renderer>().material.color = color;
            yield return new WaitForSeconds((float)0.3);
            Cube.GetComponent<Renderer>().material.color = Color.white;
            yield return new WaitForSeconds((float)0.3);
            Cube.GetComponent<Renderer>().material.color = color;
        Debug.Log("END HELP");
    }
    public void OpenHelp(string level)
    {
        if (!PlayerPrefs.HasKey(level))
        {
            PlayerPrefs.SetInt(level, 0);
        }
        if (!PlayerPrefs.HasKey("levelHelp"))
        {
            PlayerPrefs.SetInt("currentlevelHelp", 1);
        }
        if (PlayerPrefs.GetInt("coins") >= 5 && PlayerPrefs.GetInt(level)== 0)
        {
            Debug.Log("Buy Help for level"+level);
            PlayerPrefs.SetInt("currentlevelHelp", System.Convert.ToInt32(level));
            SceneManager.LoadScene("BuyHelp");
        }
        else
        {
            if (PlayerPrefs.GetInt(level) == 1)
            {
                StartCoroutine(ChangeColor(Cube));
            }
            else
            {
                SceneManager.LoadScene("WatchAds");
            }
        }
    }
}

