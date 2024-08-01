using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Madeiras : MonoBehaviour
{
    public GameObject interactionPrompt, item, Inventario;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    public int fred;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        interactionPrompt.SetActive(false);
  
    }

    void Update()
    {


        if(MadeirasQueEuTenho.possoPegar == true)
        {
            Inventario.SetActive(true);


        }
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= interactionRange && MadeirasQueEuTenho.possoPegar == true)
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
        MadeirasQueEuTenho.Madeiras++;
        Destroy(gameObject);
        if(fred == 0)
        {
            Inventario.SetActive(true);
            fred++;
        }

    }
   

}

