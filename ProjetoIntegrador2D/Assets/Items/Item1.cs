using UnityEngine;

public class Item1 : MonoBehaviour
{
    public GameObject[] item1;
    public GameObject interactionPrompt;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    public GameObject tela;

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
        tela.SetActive(true);
        if (inv.lugar == 4)
        {
            item1[3].SetActive(true);
            inv.lugar++;
            inv.i54 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 3)
        {
            item1[2].SetActive(true);
            inv.lugar++;
            inv.i53 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 2)
        {
            item1[1].SetActive(true);
            inv.lugar++;
            inv.i52 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 1)
        {
            item1[0].SetActive(true);
            inv.lugar++;
            inv.i51 = true;
            Destroy(gameObject);
        }
    }
}

public static class inv
{
    public static bool i11, i12, i13, i14, i21, i22, i23, i24, i31, i32, i33, i34, i41, i42, i43, i44, i51, i52, i53, i54, i61, i62, i63, i64, i71, i72, i73, i74;  

    public static int lugar = 1;


}