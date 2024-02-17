using UnityEngine;

public class VerkaufBehaviour : MonoBehaviour
{   
    public static int coins = -2;
    public string mytag;
    private void OnTriggerEnter(Collider other) {
        
        if (mytag == other.gameObject.tag){
            coins += 1;
            Destroy(other);
        }
    }
}
