using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{   
    public GameObject[] UIElement;
    public void PlayAgain()
    {   
        for (int i = 0; i < UIElement.Length; i++)
        {
            UIElement[i].SetActive(false);
            SceneManager.LoadScene(0);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {   
        for (int i = 0; i < UIElement.Length; i++)
        {
        UIElement[i].SetActive(true);
        Cursor.lockState = CursorLockMode.None; // Mauszeiger sperren
        Cursor.visible = true;
        }
    }    
}
