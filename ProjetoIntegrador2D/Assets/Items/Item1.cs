using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item1 : MonoBehaviour
{
    public GameObject[] item1;
    private void OnMouseDown()
    {
        
        

       
        if (inv.lugar == 4)
        {
            item1[3].SetActive(true);
            inv.lugar++;
            inv.i14 = true;
            Destroy(gameObject);
        }
        if (inv.lugar == 3)
        {
            item1[2].SetActive(true);
            inv.lugar++;
            inv.i13 = true;
            Destroy(gameObject);

        }
        if (inv.lugar == 2)
        {
            item1[1].SetActive(true);
            inv.lugar++;
            inv.i12 = true;
            Destroy(gameObject);

        }
        if (inv.lugar == 1)
        {
            item1[0].SetActive(true);
            inv.lugar++;
            inv.i11 = true;
            Destroy(gameObject);

        }



    }
    
}
public static class inv
{
    public static bool i11, i12, i13, i14, i21, i22, i23, i24, i31, i32, i33, i34, i41, i42, i43, i44, i51, i52, i53, i54, i61, i62, i63, i64, i71, i72, i73, i74;

    public static int lugar = 1;


}