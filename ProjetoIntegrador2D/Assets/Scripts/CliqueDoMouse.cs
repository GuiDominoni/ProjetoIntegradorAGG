using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CliqueDoMouse : MonoBehaviour
{
    // Tag dos itens
    public string item1 = "Item";
    public GameObject[] ItemN1;
    public int luga = 0;

    void Update()
    {
        // Detecta se o botão esquerdo do mouse foi clicado
        if (Input.GetMouseButtonDown(0))
        {
            // Converte a posição do mouse em uma posição no mundo 2D
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Realiza um Raycast2D da posição do mouse
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            // Verifica se o Raycast2D colidiu com um objeto
            if (hit.collider != null && hit.collider.CompareTag(item1))
            {
                
                Destroy(hit.collider.gameObject);
                ItemN1[luga].SetActive(true);
                luga += 1;
            }
        }
        Inv.lugar = luga;
    }
}
public static class Inv
{
    public static int lugar;


}

