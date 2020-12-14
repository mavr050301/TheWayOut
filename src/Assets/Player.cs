using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    [SerializeField] Vector3 moveDirection;
  
    private void FixedUpdate() 
    {
        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if (Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("QUIT TO MENU");
            SceneManager.LoadScene(0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            if (SceneManager.GetActiveScene().buildIndex == LevelManager.countUnlockedLevel)
            {
                LevelManager.countUnlockedLevel++;
                PlayerPrefs.SetInt("Levels", LevelManager.countUnlockedLevel);//Сохраняем значение после его изменения.
               
            } 
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins")+5);
            Debug.Log("YOU WIN!!!");
            SceneManager.LoadScene(0);
        }
        if ((this.CompareTag("Cube") && other.CompareTag("Cube")))
        {
            foreach (Activator button in FindObjectsOfType<Activator>())
                        {
                button.canPush = false;
                }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if ((this.CompareTag("Cube") && other.CompareTag("Cube")))
         {
            foreach (Activator button in FindObjectsOfType<Activator>())
            {
                button.canPush = true;
            }
        }
    }
}
