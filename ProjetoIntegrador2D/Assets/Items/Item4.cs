using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item4 : MonoBehaviour
{
    public GameObject[] item4;
    private void OnMouseDown()
    {




        if (inv.lugar == 4)
        {
            item4[3].SetActive(true);
            inv.lugar++;
            inv.i44 = true;
            Destroy(gameObject);
        }
        if (inv.lugar == 3)
        {
            item4[2].SetActive(true);
            inv.lugar++;
            inv.i43 = true;
            Destroy(gameObject);

        }
        if (inv.lugar == 2)
        {
            item4[1].SetActive(true);
            inv.lugar++;
            inv.i42 = true;
            Destroy(gameObject);

        }
        if (inv.lugar == 1)
        {
            item4[0].SetActive(true);
            inv.lugar++;
            inv.i41 = true;
            Destroy(gameObject);

        }



    }
}
