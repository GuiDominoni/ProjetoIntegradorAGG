using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaMeioCima2 : MonoBehaviour
{

    public GameObject pretoMeio, pretoCima;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            pretoMeio.SetActive(false);
            pretoCima.SetActive(true);


        }


    }
}
