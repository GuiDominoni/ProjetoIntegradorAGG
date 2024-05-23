    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaMeioEsquerda : MonoBehaviour
{
    public GameObject pretoMeio, pretoEsquerda;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            pretoMeio.SetActive(false);
            pretoEsquerda.SetActive(true);


        }


    }
}
