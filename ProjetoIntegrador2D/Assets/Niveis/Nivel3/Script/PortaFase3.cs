
using UnityEngine;

public class PortaFase3 : MonoBehaviour
{

    public GameObject interactionPrompt;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    public bool podeAbrir;
    Eletricista eletricista;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        interactionPrompt.SetActive(false);
       
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= interactionRange && podeAbrir)
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
        eletricista = FindObjectOfType(typeof(Eletricista)) as Eletricista;
        eletricista.podeSeMecher = true;
        Destroy(gameObject);
    }
}