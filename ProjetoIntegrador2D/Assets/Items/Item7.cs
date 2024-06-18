using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item7 : MonoBehaviour
{
    public GameObject[] item7;
    private void OnMouseDown()
    {




        if (inv.lugar == 4)
        {
            item7[3].SetActive(true);
            inv.lugar++;
            inv.i74 = true;
            Destroy(gameObject);
        }
        if (inv.lugar == 3)
        {
            item7[2].SetActive(true);
            inv.lugar++;
            inv.i73 = true;
            Destroy(gameObject);

        }
        if (inv.lugar == 2)
        {
            item7[1].SetActive(true);
            inv.lugar++;
            inv.i72 = true;
            Destroy(gameObject);

        }
        if (inv.lugar == 1)
        {
            item7[0].SetActive(true);
            inv.lugar++;
            inv.i71 = true;
            Destroy(gameObject);

        }



    }
}
