using UnityEngine;

public class Item3 : MonoBehaviour
{
    public GameObject[] item3;
    public GameObject interactionPrompt, item; public KeyCode interactionKey = KeyCode.E;
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
    public void ignora()
    {
        preto.SetActive(false);
        item.SetActive(false);
        pega.SetActive(false);
        ignorar.SetActive(false);
        Time.timeScale = 1;

    }

    public void Interact()
    {
        preto.SetActive(true);
        item.SetActive(true);
        pega.SetActive(true);
        ignorar.SetActive(true);
        Time.timeScale = 0;
    }
    public void pegar()
    {
    
        if (inv.lugar == 4)
        {
            item3[3].SetActive(true);
            inv.lugar++;
            inv.i34 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 3)
        {
            item3[2].SetActive(true);
            inv.lugar++;
            inv.i33 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 2)
        {
            item3[1].SetActive(true);
            inv.lugar++;
            inv.i32 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 1)
        {
            item3[0].SetActive(true);
            inv.lugar++;
            inv.i31 = true;
            Destroy(gameObject);
        }
        ignora();
    }
}
