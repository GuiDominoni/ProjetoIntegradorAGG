using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HomemDaPonte : MonoBehaviour
{
    public GameObject[] item5;
    public GameObject interactionPrompt, item, colisor, inventario;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    public int Ordem, OP, madeirasQFalta, a;
    public string aviso1, aviso2;
    public UnityEvent Fala1, Fala2, Fala3, desativ1, desativ2, ativarPonte;
    public Text texto1;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        interactionPrompt.SetActive(false);
        madeirasQFalta = 4;
    }

    void Update()
    {
       
        if (Ordem <= 2) { texto1.text = "Eu ainda preciso de " + madeirasQFalta.ToString() + " madeiras para poder construir a ponte"; }
        if (Ordem >= 3) { texto1.text = "Valeu cara"; }
        

        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= interactionRange && Ordem != 3 && a == 0)
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
        if(madeirasQFalta <= 0)
        {
            
            ativarPonte.Invoke();
            Destroy(colisor);
            Ordem++;
            a++;
            MadeirasQueEuTenho.possoPegar = false;
        }
    }
    
  
    public void Interact()
    {
        if(Ordem == 0)
        {
            Fala1.Invoke();

        }
        else if(Ordem == 1) 
        {
            MadeirasQueEuTenho.possoPegar = true;
            Fala2.Invoke();
            if(OP == 1)
            {
                madeirasQFalta -= MadeirasQueEuTenho.Madeiras;
                MadeirasQueEuTenho.Madeiras = 0;

            }


        }


    }
    public void vouTeAjudar()
    {
        Ordem++;
        desativ1.Invoke();
        OP =1;
        MadeirasQueEuTenho.possoPegar = true;

    }
    public void tchau1()
    {
        desativ1.Invoke();


    }
    public void tchau2()
    {
        desativ2.Invoke();


    }

}
public static class MadeirasQueEuTenho
{

    public static int Madeiras;
    public static bool possoPegar;

}