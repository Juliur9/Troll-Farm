using UnityEngine;
using UnityEngine.UI;

public class ButtonTroller : MonoBehaviour
{
    public RectTransform canvasRectTransform;

    void Start()
    {
        InvokeRepeating("RandomizePosition", 0f, 0.5f); // Die Position alle 0.5 Sekunden aktualisieren
    }

    void RandomizePosition()
    {
        // Zufällige Position innerhalb des Canvas berechnen
        float randomX = Random.Range(-canvasRectTransform.rect.width / 2.5f, canvasRectTransform.rect.width / 2.5f);
        float randomY = Random.Range(-canvasRectTransform.rect.height / 2.2f, canvasRectTransform.rect.height / 2.2f);

        // Neue Position für den Button setzen
        Vector3 newPosition = new Vector3(randomX, randomY, 0f);
        GetComponent<Transform>().localPosition = newPosition;
    }
}