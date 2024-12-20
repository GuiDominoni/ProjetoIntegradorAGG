
using UnityEngine;

public class Item10 : MonoBehaviour
{
    public GameObject[] item1;
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

    public void Interact()
    {
        preto.SetActive(true);
        item.SetActive(true);
        pega.SetActive(true);
        ignorar.SetActive(true);
        Time.timeScale = 0;
      
    }
    public void ignora()
    {
        preto.SetActive(false);
        item.SetActive(false);
        pega.SetActive(false);
        ignorar.SetActive(false);
        Time.timeScale = 1;
       

    }
    public void pegar()
    {
        if (inv.lugar == 4)
        {
            item1[3].SetActive(true);
            inv.lugar++;
            inv.i104 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 3)
        {
            item1[2].SetActive(true);
            inv.lugar++;
            inv.i103 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 2)
        {
            item1[1].SetActive(true);
            inv.lugar++;
            inv.i102 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 1)
        {
            item1[0].SetActive(true);
            inv.lugar++;
            inv.i101 = true;
            Destroy(gameObject);
        }
        ignora();
       
    }
}

