using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CliqueDoMouse : MonoBehaviour
{
    public GameObject Item1, Item2, Item3, Item4; // Array de imagens para ativar

    private void Update()
    {
        Debug.Log(Inv.lugar);

    }
    private void OnMouseDown()
    {
        
          
          
         
        if (Inv.lugar == 4)
        {
                Item4.SetActive(true);
                Destroy(gameObject);
            Inv.lugar += 1;


        }
        if (Inv.lugar == 3)
        {
            Item3.SetActive(true);
            Destroy(gameObject);
            Inv.lugar += 1;


        }
        if (Inv.lugar == 2)
        {
            Item2.SetActive(true);
            Destroy(gameObject);
            Inv.lugar += 1;


        }
        if (Inv.lugar == 1)
        {
            Item1.SetActive(true);
            Destroy(gameObject);
            Inv.lugar += 1;


        }




    }
   
}
public static class Inv
{
    public static int lugar = 1;


}

    
    
