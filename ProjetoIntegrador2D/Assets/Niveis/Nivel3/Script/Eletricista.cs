using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Eletricista : MonoBehaviour
{
    public Transform[] pontos;
    private Rigidbody2D rb;
    private int i = 0;
    bool jaParei, jaChameiACorroutina;
    public bool podeSeMecher;
    public GameObject[] luzes;

   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        if (podeSeMecher)
        {
            transform.position = Vector2.MoveTowards(transform.position, pontos[i].position, 4f * Time.deltaTime);

            print("Valor de I é " + i);

            if (Vector3.Distance(transform.position, pontos[i].position) < 0.4f)
            {
                if (!jaParei)
                {
                    i++;
                }
                else
                {
                    i--;
                    if (i == 0)
                    {
                        StartCoroutine(Sumir());

                    }
                }


            }
            if (i == pontos.Length && !jaChameiACorroutina)
            {
                StartCoroutine(ParadoNoGerador());


            }
        }

    }
    IEnumerator ParadoNoGerador()
    {
        jaChameiACorroutina = true;
        yield return new WaitForSeconds(6);
        for (int i = 0; i < luzes.Length; i++)
        {

            luzes[i].SetActive(false);

        }
        yield return new WaitForSeconds(2);
        i = pontos.Length;
        i--;
        jaParei = true;
        


    }
    IEnumerator Sumir()
    {
       
        yield return new WaitForSeconds(9);
        gameObject.SetActive(false);
       



    }



}
