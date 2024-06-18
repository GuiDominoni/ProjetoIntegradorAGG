using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item5 : MonoBehaviour
{
    public GameObject[] item5;
    private void OnMouseDown()
    {




        if (inv.lugar == 4)
        {
            item5[3].SetActive(true);
            inv.lugar++;
            inv.i54 = true;
            Destroy(gameObject);
        }
        if (inv.lugar == 3)
        {
            item5[2].SetActive(true);
            inv.lugar++;
            inv.i53 = true;
            Destroy(gameObject);

        }
        if (inv.lugar == 2)
        {
            item5[1].SetActive(true);
            inv.lugar++;
            inv.i52 = true;
            Destroy(gameObject);

        }
        if (inv.lugar == 1)
        {
            item5[0].SetActive(true);
            inv.lugar++;
            inv.i51 = true;
            Destroy(gameObject);

        }



    }
}
