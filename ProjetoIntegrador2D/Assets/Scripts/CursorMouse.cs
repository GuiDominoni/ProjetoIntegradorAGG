using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorMouse : MonoBehaviour
{
    public Sprite defaultCursorSprite;
    public Sprite hoverCursorSprite;
    private Image cursorImage;
    private Canvas cursorCanvas;

    void Start()
    {
        cursorImage = GetComponent<Image>();
        cursorCanvas = GetComponentInParent<Canvas>();

        cursorImage.sprite = defaultCursorSprite;
        Cursor.visible = false;

        // Definir a ordem do Canvas para garantir que o cursor esteja no topo
        cursorCanvas.sortingOrder = int.MaxValue;
    }

    void Update()
    {
        Vector2 cursorPos = Input.mousePosition;
        cursorImage.transform.position = cursorPos;
    }

    public void SetDefaultCursor()
    {
        cursorImage.sprite = defaultCursorSprite;
    }

    public void SetHoverCursor()
    {
        cursorImage.sprite = hoverCursorSprite;
    }
}
