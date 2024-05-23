using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaMeioEsquerda2 : MonoBehaviour
{

    public GameObject pretoMeio, pretoEsquerda;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            pretoMeio.SetActive(true);
            pretoEsquerda.SetActive(false);


        }


    }
}
