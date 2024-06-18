using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item2 : MonoBehaviour
{
    public GameObject[] item2;
    private void OnMouseDown()
    {




        if (inv.lugar == 4)
        {
            item2[3].SetActive(true);
            inv.lugar++;
            inv.i24 = true;
            Destroy(gameObject);
        }
        if (inv.lugar == 3)
        {
            item2[2].SetActive(true);
            inv.lugar++;
            inv.i23 = true;
            Destroy(gameObject);

        }
        if (inv.lugar == 2)
        {
            item2[1].SetActive(true);
            inv.lugar++;
            inv.i22 = true;
            Destroy(gameObject);

        }
        if (inv.lugar == 1)
        {
            item2[0].SetActive(true);
            inv.lugar++;
            inv.i21 = true;
            Destroy(gameObject);

        }



    }

}