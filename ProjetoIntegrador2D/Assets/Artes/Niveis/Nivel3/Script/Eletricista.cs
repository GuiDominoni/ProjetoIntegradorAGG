using System.Collections;
using UnityEngine;


public class Eletricista : MonoBehaviour
{
    public Transform[] pontos;
    private int i = 0;
    bool jaParei, jaChameiACorroutina, comeceiAndar;
    public bool podeSeMecher;
    public GameObject[] luzes;
    Animator anim;
    bool invertiEscala;
   

    void Start()
    {

        anim = GetComponent<Animator>();
        
    }

    void Update()
    {
        if(i == pontos.Length &&  !invertiEscala) 
        {
            transform.localScale *= new Vector2(-1, 1);
            invertiEscala = true;
        }
        if (podeSeMecher)
        {
            if(!comeceiAndar)  
            {
                anim.SetBool("Andando", true);
                comeceiAndar = true;
            }
            transform.position = Vector2.MoveTowards(transform.position, pontos[i].position, 4f * Time.deltaTime);

         

            if (Vector3.Distance(transform.position, pontos[i].position) < 0.4f)
            {
                if (!jaParei)
                {
                    i++;

                }
                else
                {
                    i--;
                    anim.SetBool("Andando", true);
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
        anim.SetBool("Andando", false);
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
        yield return new WaitForSeconds(6.5f);
        anim.SetBool("Andando", false); 
        yield return new WaitForSeconds(2.5f);
        gameObject.SetActive(false);
       



    }



}
