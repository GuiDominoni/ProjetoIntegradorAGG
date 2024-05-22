using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta1 : MonoBehaviour
{
    public GameObject PretoMeio, PretoComeco;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PretoMeio.SetActive(false);
            PretoComeco.SetActive(true);

        }
    }
}
