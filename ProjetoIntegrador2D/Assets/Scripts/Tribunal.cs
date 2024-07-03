using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tribunal : MonoBehaviour
{
    public GameObject[] falas, pergunta;
    public bool venceu, perdeu;
    public GameObject menuVenceu, menuPerdeu, unfade, fade, aviso1, aviso2, proximoNivel;
    public int cond = 0;
    public Image healthBarFill; // Referência ao Image de preenchimento
    public float vida, vidaMaxima, vidaMinima, condVerdadeira;
    public bool cli1, cli2, cli3, cli4, cli5, cli6, cli7, clicou1, clicou2, clicou3, clicou4;
   
    public void i1()
    {

        
        if(clicou1 == false)
        {
            cli1 = true;
            clicou1 = true;

        }


    }
    public void i2()
    {

        cli2 = true;


    }
    public void i3()
    {


        cli3 = true;

    }
    public void i4()
    {
        cli4 = true;



    }
    public void i5()
    {


        cli5 = true;

    }
    public void i6()
    {

        cli6 = true;


    }
    public void i7()
    {

        cli7 = true;


    }

    public void Recomeçar()
    {
        unfade.SetActive(true);
        Invoke("Recomec", 0.4f);
        

    }
    public void proxNv()
    {
        proximoNivel.SetActive(true);



    }
    public void Sair()
    {
        proximoNivel.SetActive(false);



    }
    public void Jogar()
    {
        unfade.SetActive(true);
        Invoke("Mapa2", 0.4f);



    }
    void Recomec()
    {
        SceneManager.LoadScene("Fase1Tutorial");

    }
    public void selecaoDeNiveis()
    {
        unfade .SetActive(true);
        Invoke("SelecNiveis", 0.4f);

    }
    public void Mapa2()
    {
        SceneManager.LoadScene("Mapa2");


    }
    public void SelecNiveis()
    {
        SceneManager.LoadScene("SelecaoNiveis");


    }
    public void desatPreto()
    {
        fade.SetActive(false);


    }
    private void Update()
    {
        if (pergunta[1].activeSelf && clicou1)
        {
            if( cli1 == true)
            {

                cond++;

            }
           
            pergunta[1].SetActive(false);
            pergunta[2].SetActive(true);
            



        }
        if (pergunta[2].activeSelf)
        {
            if (cli7 == true)
            {

                cond++;

            }
            pergunta[2].SetActive(false);
            pergunta[3].SetActive(true);
           
                
        }
        if (pergunta[3].activeSelf)
        {
            if (cli4 == true)
            {

                cond++;

            }
            pergunta[3].SetActive(false);
            pergunta[4].SetActive(true);
           
        }
        if (pergunta[4].activeSelf)
        {
            cond++;
            pergunta[4].SetActive(false);
            condVerdadeira = cond;
           

        }
        Debug.Log(cli1);
        Debug.Log(cli2);
        Debug.Log(cli3);
        Debug.Log(cli4);
        Debug.Log(cli5);
        Debug.Log(cli6);
        Debug.Log(cli7);
        vida = cond * 25;
        if (vida >= vidaMinima && vida <= vidaMaxima)
        {
            healthBarFill.fillAmount = vida / 100;


        }

        Debug.Log(cond);
        if (venceu == true)
        {
            menuVenceu.SetActive(true);
            GlobalVariaveis.n2 = 1;


        }
        if (perdeu == true)
        {
            menuPerdeu.SetActive(true);


        }


    }
    private void Start()
    {
        Invoke("desatPreto", 1);
        vidaMaxima = 100;
        vidaMinima = 0;
        vida = 0;

    }

}
