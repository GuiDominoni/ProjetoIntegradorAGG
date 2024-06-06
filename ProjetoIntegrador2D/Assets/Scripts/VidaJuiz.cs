using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaJuiz : MonoBehaviour
{
    public Image healthBarFill; // Referência ao Image de preenchimento
    public float vida, vidaMaxima, vidaMinima;
    private void Start()
    {
        vidaMaxima = 100;
        vidaMinima = 0;
        vida = 50;
        
    }
    private void Update()
    {
        if(vida >= vidaMinima && vida <= vidaMaxima)
        {
            healthBarFill.fillAmount = vida / 100;
        
        
        }


    }

}
