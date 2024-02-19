using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{   
    public GameObject UIElement;
    public void PlayAgain()
    {   
        UIElement.SetActive(false);
        SceneManager.LoadScene(0);
    }
    private void OnTriggerEnter(Collider other)
    {
        UIElement.SetActive(true);
        Cursor.lockState = CursorLockMode.None; // Mauszeiger sperren
        Cursor.visible = true;
    }    
}
