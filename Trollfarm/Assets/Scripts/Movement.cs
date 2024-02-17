using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Movement : MonoBehaviour

{
    public float rotatespeed; // Die Rotationsgeschwindigkeit des Spielers.
    public float movespeed;   // Die Geschwindigkeit der Bewegung des Spielers.
    public Rigidbody rb;      // Die Rigidbody-Komponente des Spielers.
    [SerializeField] private Transform transformcamera;

    private float cameraRotationX = 0f;
 
    void Start()
{
    Cursor.lockState = CursorLockMode.Locked; // Mauszeiger sperren
    Cursor.visible = false; // Mauszeiger ausblenden     
}
void Update()
    {   

        float moveX = Input.GetAxis("Vertical") * movespeed; // Die Eingabe für die Vorwärts- und Rückwärtsbewegung.
        float moveZ = Input.GetAxis("Horizontal") * movespeed; // Die Eingabe für die seitliche Bewegung.
        float rotateY = Input.GetAxis("Mouse X") * rotatespeed * Time.deltaTime; // Die Mausbewegung zur horizontalen Drehung.
        float rotateX = Input.GetAxis("Mouse Y") * rotatespeed * Time.deltaTime; // Die Mausbewegung zur vertikalen Drehung.

        cameraRotationX -= rotateX;
        cameraRotationX = Mathf.Clamp(cameraRotationX, -90f, 90f); // Begrenze die vertikale Rotation, um Überkopfrotationen zu vermeiden.

        // Die Kamera um die X-Achse (vertikal) drehen
        transformcamera.localRotation = Quaternion.Euler(cameraRotationX, 0f, 0f);

        // Den Spieler basierend auf der Mausbewegung drehen
        transform.Rotate(0f, rotateY, 0f); // Die horizontale Drehung des Spielers.

        // Die Bewegungsrichtung basierend auf der Spielerrotation berechnen
        Vector3 moveDirection = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0) * new Vector3(moveZ, 0, moveX); // Die Bewegungsrichtung basierend auf der Spielerrotation.
        Vector3 movement = moveDirection.normalized * movespeed; // Die normierte Bewegung mit der Geschwindigkeit multiplizieren.

        rb.velocity = new Vector3(movement.x, rb.velocity.y , movement.z); // Die Bewegung des Spielers aktualisieren.
    }
    
}