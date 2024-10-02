using UnityEngine;

public class CartazFase3 : MonoBehaviour
{
   
    public GameObject interactionPrompt;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    public GameObject[] itensDoCartaz;
    public  bool podeInteragir;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        interactionPrompt.SetActive(false);
        podeInteragir = true;   
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= interactionRange && podeInteragir)
        {
            interactionPrompt.SetActive(true);
            interactionPrompt.transform.position = transform.position + new Vector3(0, 1.5f, 0); // Posiciona o texto acima do objeto

            if (Input.GetKeyDown(interactionKey))
            {
                Interact(true);
            }
        }
        else
        {
            interactionPrompt.SetActive(false);
        }
    }


    public void Interact(bool Qual)
    {
       for (int i = 0; i < itensDoCartaz.Length; i++) 
       {
            itensDoCartaz[i].SetActive(Qual);
        
            
       }
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            Cursor.visible = true;

        }
        else
        {

            Time.timeScale = 1;
            Cursor.visible = false;

        }
        podeInteragir = false;

    }
    public void PodeInteragir()
    {
            
        podeInteragir = true;
    }

}
