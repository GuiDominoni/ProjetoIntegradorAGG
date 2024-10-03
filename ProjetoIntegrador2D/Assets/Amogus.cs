using UnityEngine;

public class Amogus : MonoBehaviour
{
    private void OnMouseDrag()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log("Dragging: " + mousePosition); // Isso vai imprimir a posição do mouse no console
        transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
    }
}
