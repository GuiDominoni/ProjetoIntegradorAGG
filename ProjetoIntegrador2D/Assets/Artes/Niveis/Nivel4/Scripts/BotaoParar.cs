using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoParar : MonoBehaviour
{
 
    public GameObject interactionPrompt;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    EsteiraFase4 esteiraFase4;
    // Start is called before the first frame update
    void Start()
    {
        esteiraFase4 = FindObjectOfType<EsteiraFase4>();
    }

    // Update is called once per frame
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
    void Interact()
    {
        esteiraFase4.InverterVelo();


    }
}
