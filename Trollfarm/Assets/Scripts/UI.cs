using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{   
    public void PlayAgain()
    {   
        SceneManager.LoadScene(1);
        Cursor.lockState = CursorLockMode.Locked; // Mauszeiger sperren
        Cursor.visible = false; // Mauszeiger ausblenden
        
        
    }
    private void OnTriggerEnter(Collider other)
    {   
        SceneManager.LoadScene(0);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }    
}
