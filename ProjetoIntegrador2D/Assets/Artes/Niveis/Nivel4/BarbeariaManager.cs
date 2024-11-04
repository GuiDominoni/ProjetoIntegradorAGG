using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbeariaManager : MonoBehaviour
{
    public int emQualEsta;
    public GameObject[] Visuais;
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
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
                if (emQualEsta == 2)
                {
                    Visuais[emQualEsta].SetActive(false);
                    emQualEsta = 0;
                    Visuais[emQualEsta].SetActive(true);
                }
                else { Visuais[emQualEsta].SetActive(false);  emQualEsta++; Visuais[emQualEsta].SetActive(true); }

                break;
            case false:
                if (emQualEsta == 0)
                {
                    Visuais[emQualEsta].SetActive(false);
                    emQualEsta = 2;
                    Visuais[emQualEsta].SetActive(true);
                }
                else { Visuais[emQualEsta].SetActive(false); emQualEsta--; Visuais[emQualEsta].SetActive(true); }
                break;


        }

    }
    public void Selecionar()
    {
        player.qualAnimator = emQualEsta + 1;
    }
}
