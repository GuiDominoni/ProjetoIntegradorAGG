using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CliqueDoMouse : MonoBehaviour
{
    // Tag dos itens
    public string item1 = "Item";

    public GameObject[] ItemN1;

    void Update()
    {
        // Detecta se o bot�o esquerdo do mouse foi clicado
        if (Input.GetMouseButtonDown(0))
        {
            // Converte a posi��o do mouse em uma posi��o no mundo 2D
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Realiza um Raycast2D da posi��o do mouse
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            // Verifica se o Raycast2D colidiu com um objeto
            if (hit.collider != null && hit.collider.CompareTag(item1))
            {
                Inv.lugar += 1;
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
public static class Inv
{
    public static int lugar = 1;


}

