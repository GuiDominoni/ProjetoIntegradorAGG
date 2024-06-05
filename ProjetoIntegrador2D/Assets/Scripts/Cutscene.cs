using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Cutscene : MonoBehaviour
{
    public Image cut1, cut2, cut3, cut4, cut5, cut6, cut7, cut8, cut9, cut10;
    public void Sair()
    {
        SceneManager.LoadScene("SelecaoNiveis");
    }
    public void proximo()
    {
        if(Cut.c1 == 1)
        {
            Cut.c1 = 0;
            Cut.c2 = 1;

        }
        if (Cut.c1 == 2)
        {


        }
        if (Cut.c1 == 3)
        {


        }
        if (Cut.c1 == 4)
        {


        }
        if (Cut.c1 == 5)
        {


        }
        if (Cut.c1 == 6)
        {


        }
        if (Cut.c1 == 7)
        {


        }
        if (Cut.c1 == 8)
        {


        }
        if (Cut.c1 == 9)
        {


        }
        if (Cut.c1 == 10)
        {


        }

    }

}
public static class Cut
{
    public static float c1 = 1, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0, c10 = 0;


}
