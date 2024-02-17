using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    private GameObject grabbedObject;
    private bool isGrabbing = false;
    public Transform transformcamera;

    // Das Tag des Objekts, das aufgehoben werden soll
    public string objectTag = "Interactable";

    void Update()
    {
        // Wenn die linke Maustaste gedrückt wird
        if (Input.GetButtonDown("Jump"))
        {   
            // Wenn nicht bereits ein Objekt aufgehoben wird
            if (!isGrabbing)
            {
                // Aufheben des nächsten Objekts mit dem angegebenen Tag in Reichweite
                GrabObject();
            }
            else
            {
                // Loslassen des aktuellen Objekts
                DropObject();
            }
        }
    }

    void GrabObject()
{
    RaycastHit hit;
    Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

    if (Physics.Raycast(ray, out hit))
    {
        if (hit.collider.gameObject.CompareTag(objectTag))
        {   
            grabbedObject = hit.collider.gameObject;
            grabbedObject.GetComponent<Rigidbody>().isKinematic = true;
            isGrabbing = true;
            grabbedObject.transform.parent = transformcamera;
            grabbedObject.transform.localPosition = new Vector3(0f, 0f, 0.7f);
        }
    }
}

    void DropObject()
    {
        // Entferne das aufgehobene Objekt als Kind des Spielers
        grabbedObject.transform.parent = null;
        grabbedObject.GetComponent<Rigidbody>().isKinematic = false;
        isGrabbing = false;
        grabbedObject = null;
    }
}
