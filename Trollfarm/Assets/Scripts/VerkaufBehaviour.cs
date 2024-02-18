using UnityEngine;

public class VerkaufBehaviour : MonoBehaviour
{   
    public ObjectInteraction objecti;
    public string mytag;
    [SerializeField] private int coinsperveg; 
    private void OnTriggerEnter(Collider other) {
        
        if (mytag == other.gameObject.tag){
            objecti.coins += coinsperveg;
            Debug.Log(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}
