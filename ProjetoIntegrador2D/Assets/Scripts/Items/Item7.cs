using UnityEngine;

public class Item7 : MonoBehaviour
{
    public GameObject[] item7, verdes;
    public GameObject interactionPrompt, item;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    public GameObject preto, pega, ignorar;
    public bool podeInteragir;
    private void Start()
    {
        podeInteragir = true;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        interactionPrompt.SetActive(false);
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= interactionRange && podeInteragir && inv.possoPegarOItem)
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
            item7[3].SetActive(true);
            inv.lugar++;
            inv.i74 = true;
            
        }
        else if (inv.lugar == 3)
        {
            item7[2].SetActive(true);
            inv.lugar++;
            inv.i73 = true;
            
        }
        else if (inv.lugar == 2)
        {
            item7[1].SetActive(true);
            inv.lugar++;
            inv.i72 = true;
            
        }
        else if (inv.lugar == 1)
        {
            item7[0].SetActive(true);
            inv.lugar++;
            inv.i71 = true;
            
        }
        if(GlobalVariaveis.emQueNivelEstou == 2)
        {
            
            podeInteragir = false;

        }
        if (GlobalVariaveis.emQueNivelEstou == 1)
        {

            Destroy(gameObject);
        }
        ignora();
        Cursor.visible = false;
    }
}
