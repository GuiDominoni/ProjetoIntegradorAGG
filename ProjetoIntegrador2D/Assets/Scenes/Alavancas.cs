using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alavancas : MonoBehaviour
{
    public GameObject interactionPrompt;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    AlavancaManager alavancaManager;
    public int num1, num2, num3, num4;
    SpriteRenderer spriteRenderer;
    public Sprite AlavancaCima, AlavancaBaixo;
    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        interactionPrompt.SetActive(false);
      alavancaManager = FindObjectOfType<AlavancaManager>();
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

    public void Interact()
    {
       
      if(spriteRenderer.sprite == AlavancaCima) 
        {
            spriteRenderer.sprite = AlavancaBaixo;

        }
        else
        {
            spriteRenderer.sprite = AlavancaCima;

        }
      
        alavancaManager.MudarAlavancas(num1);
        alavancaManager.MudarAlavancas(num2);
        alavancaManager.MudarAlavancas(num3);
        alavancaManager.MudarAlavancas(num4);
        alavancaManager.ChecarAlavancas();
    }
}
