using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcionário : MonoBehaviour
{
    public GameObject interactionPrompt, falaNaoPermitida, falaPermitida;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    Player scriptPlayer;

    private void Start()
    {
        scriptPlayer = FindObjectOfType<Player>();
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
       if(scriptPlayer.qualAnimator == 2)
        {
            falaPermitida.SetActive(true);


        }
        else
        {

            falaNaoPermitida.SetActive(false);

        }
    }
    public void Sair()
    {
        falaNaoPermitida.SetActive(false);
        falaPermitida.SetActive(false);
    }
}
