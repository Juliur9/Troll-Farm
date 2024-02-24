using UnityEngine;

public class VerkaufBehaviour : MonoBehaviour
{   
    public ObjectInteraction objecti;
    public AudioSource selledaudio;
    public string mytag;
    [SerializeField] private int coinsperveg; 
    private void OnTriggerEnter(Collider other) {
        
        if (mytag == other.gameObject.tag){
            objecti.coins += coinsperveg;
            Destroy(other.gameObject);
            selledaudio.Play();
        }
    }
}
