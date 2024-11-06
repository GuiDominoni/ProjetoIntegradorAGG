using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivrosFase4 : MonoBehaviour
{
  
    public GameObject interactionPrompt;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    Player scriptPlayer;
 
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        scriptPlayer = FindObjectOfType<Player>();
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
        scriptPlayer.livros++;
        Destroy(gameObject); 
    }



}
