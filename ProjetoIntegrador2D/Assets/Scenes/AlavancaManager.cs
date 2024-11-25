using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlavancaManager : MonoBehaviour
{

    public GameObject[] portas;
    public bool[] estadoAlavancas;
    // Start is called before the first frame update
    void Start()
    {
        ChecarAlavancas();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChecarAlavancas()
    {
        for(int x = 0;  x < portas.Length; x++) 
        {
            portas[x].SetActive(estadoAlavancas[x]);
        }
    }
    public void MudarAlavancas(int qual)
    {
        estadoAlavancas[qual] = !estadoAlavancas[qual];

    }
}
