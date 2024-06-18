using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item3 : MonoBehaviour
{
    public GameObject[] item3;
    private void OnMouseDown()
    {




        if (inv.lugar == 4)
        {
            item3[3].SetActive(true);
            inv.lugar++;
            inv.i34 = true;
            Destroy(gameObject);
        }
        if (inv.lugar == 3)
        {
            item3[2].SetActive(true);
            inv.lugar++;
            inv.i33 = true;
            Destroy(gameObject);

        }
        if (inv.lugar == 2)
        {
            item3[1].SetActive(true);
            inv.lugar++;
            inv.i32 = true;
            Destroy(gameObject);

        }
        if (inv.lugar == 1)
        {
            item3[0].SetActive(true);
            inv.lugar++;
            inv.i31 = true;
            Destroy(gameObject);

        }



    }
}
