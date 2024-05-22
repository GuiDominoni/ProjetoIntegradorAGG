using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta12 : MonoBehaviour
{
    public GameObject PretoMeio, PretoComeco;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PretoMeio.SetActive(true);
            PretoComeco.SetActive(false);


        }

    }
}
