
using UnityEngine;
using UnityEngine.UI;

public class VidaJuiz : MonoBehaviour
{
    public Image healthBarFill; // ReferÍncia ao Image de preenchimento
    public float vida, vidaMaxima, vidaMinima;
    private void Start()
    {
        vidaMaxima = 100;
        vidaMinima = 0;
        vida = 0;
        
    }
    private void Update()
    {
        if(vida >= vidaMinima && vida <= vidaMaxima)
        {
            healthBarFill.fillAmount = vida / 100;
        
        
        }


    }

}
