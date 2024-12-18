using UnityEngine;

public class Item2 : MonoBehaviour
{
    public GameObject[] item2;
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

        if (distance <= interactionRange && inv.possoPegarOItem)
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
            item2[3].SetActive(true);
            inv.lugar++;
            inv.i24 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 3)
        {
            item2[2].SetActive(true);
            inv.lugar++;
            inv.i23 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 2)
        {
            item2[1].SetActive(true);
            inv.lugar++;
            inv.i22 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 1)
        {
            item2[0].SetActive(true);
            inv.lugar++;
            inv.i21 = true;
            Destroy(gameObject);
        }
        ignora();
        


    }
}
