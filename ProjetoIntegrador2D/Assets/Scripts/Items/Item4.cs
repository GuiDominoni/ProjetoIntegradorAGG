using UnityEngine;

public class Item4 : MonoBehaviour
{
    public GameObject[] item4, verdes;
    public GameObject interactionPrompt, item;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    public GameObject preto, pega, ignorar;
    bool podePegar;
    public bool vaiSerDestruido;
    private void Start()
    {
        podePegar = true;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        interactionPrompt.SetActive(false);
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= interactionRange && podePegar && inv.possoPegarOItem)
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
        Cursor.visible = false;
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
    public void pegar()
    {

        if (inv.lugar == 4)
        {
            item4[3].SetActive(true);
            inv.lugar++;
            inv.i44 = true;
           
        }
        else if (inv.lugar == 3)
        {
            item4[2].SetActive(true);
            inv.lugar++;
            inv.i43 = true;
           
        }
        else if (inv.lugar == 2)
        {
            item4[1].SetActive(true);
            inv.lugar++;
            inv.i42 = true;
           
        }
        else if (inv.lugar == 1)
        {
            item4[0].SetActive(true);
            inv.lugar++;
            inv.i41 = true;
            
        }
         podePegar = false;
        ignora();
        Cursor.visible = false;
        if(GlobalVariaveis.emQueNivelEstou != 1)
        {
            Destroy(gameObject);


        }

    }
}
