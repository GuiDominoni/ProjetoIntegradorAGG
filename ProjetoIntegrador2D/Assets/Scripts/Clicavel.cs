using UnityEngine;
using UnityEngine.EventSystems;

public class Clicavel : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private CursorMouse customCursor;

    void Start()
    {
        // Encontre o objeto Cursor no Canvas
        customCursor = FindObjectOfType<CursorMouse>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Mude o cursor para o sprite de hover
        customCursor.SetHoverCursor();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Volte o cursor para o sprite padrão
        customCursor.SetDefaultCursor();
    }
}
