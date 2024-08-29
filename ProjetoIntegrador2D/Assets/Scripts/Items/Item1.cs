
using UnityEngine;

public class Item1 : MonoBehaviour
{
    public GameObject[] item1, verdes;
    public GameObject interactionPrompt, item;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    public GameObject preto, pega, ignorar;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        interactionPrompt.SetActive(false);
    }       

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= interactionRange)
        {
            interactionPrompt.SetActive(true);
            interactionPrompt.transform.position = transform.position + new Vector3(0, 1.5f, 0); // Posiciona o texto acima do objeto

            if (Input.GetKeyDown(interactionKey))
            {
                Interact();
            }
        }
        else
        {
            interactionPrompt.SetActive(false);
        }
       
    }

    public void Interact()
    {
        preto.SetActive(true);
        item.SetActive(true);
        pega.SetActive(true);
        ignorar.SetActive(true);
        Time.timeScale = 0;
        Cursor.visible = true;
    }
    public void ignora()
    {
        preto.SetActive(false);
        item.SetActive(false);
        pega.SetActive(false);
        ignorar.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
    }
    public void pegar()
    {
        if (inv.lugar == 4)
        {
            item1[3].SetActive(true);
            inv.lugar++;
            inv.i14 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 3)
        {
            item1[2].SetActive(true);
            inv.lugar++;
            inv.i13 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 2)
        {
            item1[1].SetActive(true);
            inv.lugar++;
            inv.i12 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 1)
        {
            item1[0].SetActive(true);
            inv.lugar++;
            inv.i11 = true;
            Destroy(gameObject);
        }
        ignora();
        Cursor.visible = false;
    }
}

public static class inv
{
    public static bool i11, i12, i13, i14, i21, i22, i23, i24, i31, i32, i33, i34, i41, i42, i43, i44, i51, i52, i53, i54, i61, i62, i63, i64, i71, i72, i73, i74, i81, i82, i83, i84, i91, i92, i93, i94, i101, i102, i103, i104;  

    public static int lugar = 1;


}