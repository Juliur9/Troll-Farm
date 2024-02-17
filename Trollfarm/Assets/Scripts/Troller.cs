using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troller : MonoBehaviour
{   
    public Transform kiste;
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            kiste.position += new Vector3 (0,0, 1.2f);
        }
        
    }
    void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            kiste.position -= new Vector3 (0,0,1.2f);
        }
    }
}
