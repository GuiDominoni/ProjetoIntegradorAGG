using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraçãoCartaoPorta : MonoBehaviour
{
    public GameObject[] item7;
    public GameObject interactionPrompt;    
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    public GameObject preto, pretoQTem, pretoQvaiTer, porta;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        interactionPrompt.SetActive(false);
        GlobalVariaveis.emQueNivelEstou = 2;
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= interactionRange)
        {
            interactionPrompt.SetActive(true);
            interactionPrompt.transform.position = transform.position + new Vector3(0, 1f, 0); // Posiciona o texto acima do objeto

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
        if(Interações.TenhoCartaoFase2 == true)
        {
            pretoQvaiTer.SetActive(true);
            pretoQTem.SetActive(false);
            porta.SetActive(false);
            Destroy(gameObject);


        }
    }
   
}
