using Unity.VisualScripting;
using UnityEngine;

public class Item6 : MonoBehaviour
{
    public GameObject[] item6;
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
    public void ignora()
    {
        preto.SetActive(false);
        item.SetActive(false);
        pega.SetActive(false);
        ignorar.SetActive(false);


    }

    public void Interact()
    {
        preto.SetActive(true);
        item.SetActive(true);
        pega.SetActive(true);
        ignorar.SetActive(true);
    }
    public void pegar()
    {

        if (inv.lugar == 4)
        {
            item6[3].SetActive(true);
            inv.lugar++;
            inv.i64 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 3)
        {
            item6[2].SetActive(true);
            inv.lugar++;
            inv.i63 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 2)
        {
            item6[1].SetActive(true);
            inv.lugar++;
            inv.i62 = true;
            Destroy(gameObject);
        }
        else if (inv.lugar == 1)
        {
            item6[0].SetActive(true);
            inv.lugar++;
            inv.i61 = true;
            Destroy(gameObject);
        }
        ignora();   

    }
}
