using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaMeioCima : MonoBehaviour
{

    public GameObject pretoMeio, pretoCima;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            pretoMeio.SetActive(true);
            pretoCima.SetActive(false);


        }


    }


}
