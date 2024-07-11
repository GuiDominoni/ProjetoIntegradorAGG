using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TribunalNv2 : MonoBehaviour
{
    public GameObject[] pergunta, item1, item2, item3, item4, item5, item6, item7;
    public bool venceu, perdeu, clicouI1, clicouI2, clicouI3, clicouI4, clicouI5, clicouI6, clicouI7, clicou1, clicou2, clicou3, clicou4;
    public GameObject menuVenceu, menuPerdeu, unfade, fade;
    public int cond = 0;
    public Image healthBarFill;
    public float vida, vidaMaxima, vidaMinima;

    public void Verde()
    {
        item1[1].SetActive(false);
        item1[2].SetActive(false);
        item1[3].SetActive(false);
        item1[4].SetActive(false);



        if (clicou1 == true && clicou2 == true && clicou3 == true && clicou4 == false)
        {

            clicou4 = true;



        }
        if (clicou1 == true && clicou2 == true && clicou3 == false)
        {

            clicou3 = true;



        }
        if (clicou1 == true && clicou2 == false)
        {

            clicou2 = true;


        }

        if (clicou1 == false)
        {
            clicou1 = true;
            cond++;

        }
    }
    public void Vermelho()
    {
        item2[1].SetActive(false);
        item2[2].SetActive(false);
        item2[3].SetActive(false);
        item2[4].SetActive(false);

        if (clicou1 == true && clicou2 == true && clicou3 == true && clicou4 == false)
        {

            clicou4 = true;



        }
        if (clicou1 == true && clicou2 == true && clicou3 == false)
        {

            clicou3 = true;



        }
        if (clicou1 == true && clicou2 == false)
        {

            clicou2 = true;


        }

        if (clicou1 == false)
        {
            clicou1 = true;


        }


    }
    public void Laranja()
    {
        item3[1].SetActive(false);
        item3[2].SetActive(false);
        item3[3].SetActive(false);
        item3[4].SetActive(false);

        if (clicou1 == true && clicou2 == true && clicou3 == true && clicou4 == false)
        {

            clicou4 = true;



        }
        if (clicou1 == true && clicou2 == true && clicou3 == false)
        {

            clicou3 = true;



        }
        if (clicou1 == true && clicou2 == false)
        {

            clicou2 = true;


        }

        if (clicou1 == false)
        {
            clicou1 = true;


        }



    }
    public void Amarelo()
    {
        item4[1].SetActive(false);
        item4[2].SetActive(false);
        item4[3].SetActive(false);
        item4[4].SetActive(false);

        if (clicou1 == true && clicou2 == true && clicou3 == true && clicou4 == false)
        {

            clicou4 = true;



        }
        if (clicou1 == true && clicou2 == true && clicou3 == false)
        {

            clicou3 = true;
            cond++;


        }
        if (clicou1 == true && clicou2 == false)
        {

            clicou2 = true;


        }

        if (clicou1 == false)
        {
            clicou1 = true;


        }



    }
    public void AzulForte()
    {
        item5[1].SetActive(false);
        item5[2].SetActive(false);
        item5[3].SetActive(false);
        item5[4].SetActive(false);

        if (clicou1 == true && clicou2 == true && clicou3 == true && clicou4 == false)
        {

            clicou4 = true;



        }
        if (clicou1 == true && clicou2 == true && clicou3 == false)
        {

            clicou3 = true;



        }
        if (clicou1 == true && clicou2 == false)
        {

            clicou2 = true;


        }

        if (clicou1 == false)
        {
            clicou1 = true;


        }



    }
    public void Ciano()
    {
        item6[1].SetActive(false);
        item6[2].SetActive(false);
        item6[3].SetActive(false);
        item6[4].SetActive(false);

        if (clicou1 == true && clicou2 == true && clicou3 == true && clicou4 == false)
        {

            clicou4 = true;
            cond++;


        }
        if (clicou1 == true && clicou2 == true && clicou3 == false)
        {

            clicou3 = true;



        }
        if (clicou1 == true && clicou2 == false)
        {

            clicou2 = true;


        }

        if (clicou1 == false)
        {
            clicou1 = true;


        }



    }
    public void Rosa()
    {
        item7[1].SetActive(false);
        item7[2].SetActive(false);
        item7[3].SetActive(false);
        item7[4].SetActive(false);

        if (clicou1 == true && clicou2 == true && clicou3 == true && clicou4 == false)
        {

            clicou4 = true;



        }
        if (clicou1 == true && clicou2 == true && clicou3 == false)
        {

            clicou3 = true;



        }
        if (clicou1 == true && clicou2 == false)
        {

            clicou2 = true;
            cond++;

        }

        if (clicou1 == false)
        {
            clicou1 = true;


        }



    }


    public void Recomeçar()
    {
        unfade.SetActive(true);
        Invoke("Recomec", 0.4f);


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
        unfade.SetActive(true);
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


        if (pergunta[1].activeSelf && clicou1 == true)
        {
            pergunta[1].SetActive(false);
            pergunta[2].SetActive(true);




        }

        if (pergunta[2].activeSelf && clicou2 == true)
        {
            pergunta[2].SetActive(false);
            pergunta[3].SetActive(true);




        }

        if (pergunta[3].activeSelf && clicou3 == true)
        {
            pergunta[3].SetActive(false);
            pergunta[4].SetActive(true);




        }

        if (pergunta[4].activeSelf && clicou4 == true)
        {

            pergunta[4].SetActive(false);


        }

        vida = cond * 25;
        if (vida >= vidaMinima && vida <= vidaMaxima)
        {
            healthBarFill.fillAmount = vida / 100;


        }
        if (clicou4 == true && cond >= 3)
        {
            venceu = true;


        }
        if (clicou4 == true && cond <= 2)
        {
            perdeu = true;


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
