using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BarbeariaManager : MonoBehaviour
{
    public int emQualEsta;
    public GameObject[] Visuais;
    Player player;
    Barbeiro barbeiro;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        barbeiro = FindObjectOfType<Barbeiro>();    
        emQualEsta = 0; 
    }

    // Update is called once per frame
    void Update()
    {
          


    }
    public void BarbeariaMudar(bool aumentar)
    {
        switch(aumentar)
        {
            case true:
                Visuais[emQualEsta].SetActive(false);
                if (emQualEsta == 2)
                    emQualEsta = 0;
                else emQualEsta++;

                break;
            case false:
                Visuais[emQualEsta].SetActive(false);
                if (emQualEsta == 0)               
                    emQualEsta = 2;                
                else emQualEsta--;  
                break;
        }
        Visuais[emQualEsta].SetActive(true);

    }
    public void Sair()
    {
        barbeiro.Interact();


    }
    public void Selecionar()
    {
        if (player.livros >= 4)
        {
            player.qualAnimator = emQualEsta + 1;
            player.livros = 0;
            barbeiro.Interact();
        }
    }
}
