using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item6 : MonoBehaviour
{
    public GameObject[] item6;
    private void OnMouseDown()
    {




        if (inv.lugar == 4)
        {
            item6[3].SetActive(true);
            inv.lugar++;
            inv.i64 = true;
            Destroy(gameObject);
        }
        if (inv.lugar == 3)
        {
            item6[2].SetActive(true);
            inv.lugar++;
            inv.i63 = true;
            Destroy(gameObject);

        }
        if (inv.lugar == 2)
        {
            item6[1].SetActive(true);
            inv.lugar++;
            inv.i62 = true;
            Destroy(gameObject);

        }
        if (inv.lugar == 1)
        {
            item6[0].SetActive(true);
            inv.lugar++;
            inv.i61 = true;
            Destroy(gameObject);

        }



    }
}
