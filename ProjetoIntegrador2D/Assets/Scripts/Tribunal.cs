using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tribunal : MonoBehaviour
{
    public GameObject[] falas;
    public void fala11()
    {

        falas[1].SetActive(false);
        falas[2].SetActive(false);
        falas[3].SetActive(true);
        falas[4].SetActive(true);

    }
    public void fala12()
    {

        falas[1].SetActive(false);
        falas[2].SetActive(false);
        falas[3].SetActive(true);
        falas[4].SetActive(true);

    }
    public void fala21()
    {
        falas[3].SetActive(false);
        falas[4].SetActive(false);
        falas[5].SetActive(true);
        falas[6].SetActive(true);




    }
    public void fala22()
    {
        falas[3].SetActive(false);
        falas[4].SetActive(false);
        falas[5].SetActive(true);
        falas[6].SetActive(true);




    }
    public void fala31()
    { 

        falas[5].SetActive(false);
        falas[6].SetActive(false);
        falas[7].SetActive(true);
        falas[8].SetActive(true);




    }
    public void fala32()
    {

        falas[5].SetActive(false);
        falas[6].SetActive(false);
        falas[7].SetActive(true);
        falas[8].SetActive(true);




    }
    public void fala41()
    {
        falas[7].SetActive(false);
        falas[8].SetActive(false);
        falas[9].SetActive(true);
        falas[10].SetActive(true);


    }
    public void fala42()
    {
        falas[7].SetActive(false);
        falas[8].SetActive(false);
        falas[9].SetActive(true);
        falas[10].SetActive(true);


    }
}
