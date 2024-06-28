using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TribunalNv2 : MonoBehaviour
{
    public GameObject[] falas, pergunta;
    public bool venceu, perdeu;
    public GameObject menuVenceu, menuPerdeu, unfade, fade, aviso1, aviso2, proxNv;
    public int cond = 0;
    public Image healthBarFill; // Referência ao Image de preenchimento
    public float vida, vidaMaxima, vidaMinima;
    public void fala11()
    {

        if (inv.i21 || inv.i22 || inv.i23 || inv.i24 == true)
        {
            cond++;




            pergunta[1].SetActive(false);
            falas[1].SetActive(false);
            falas[2].SetActive(false);
            falas[3].SetActive(true);
            falas[4].SetActive(true);
            pergunta[2].SetActive(true);
        }

    }
    public void fala12()
    {
        pergunta[1].SetActive(false);
        falas[1].SetActive(false);
        falas[2].SetActive(false);
        falas[3].SetActive(true);
        falas[4].SetActive(true);
        pergunta[2].SetActive(true);

    }
    public void fala21()
    {

        if (inv.i41 || inv.i42 || inv.i43 || inv.i44 == true)
        {
            cond++;




            pergunta[2].SetActive(false);
            pergunta[3].SetActive(true);
            falas[3].SetActive(false);
            falas[4].SetActive(false);
            falas[5].SetActive(true);
            falas[6].SetActive(true);
        }




    }
    public void fala22()
    {
        pergunta[2].SetActive(false);
        pergunta[3].SetActive(true);
        falas[3].SetActive(false);
        falas[4].SetActive(false);
        falas[5].SetActive(true);
        falas[6].SetActive(true);




    }
    public void fala31()
    {

        if (inv.i51 || inv.i52 || inv.i53 || inv.i54 == true)
        {
            cond++;



            pergunta[3].SetActive(false);
            pergunta[4].SetActive(true);
            falas[5].SetActive(false);
            falas[6].SetActive(false);
            falas[7].SetActive(true);
            falas[8].SetActive(true);
        }




    }
    public void fala32()
    {
        pergunta[3].SetActive(false);
        pergunta[4].SetActive(true);
        falas[5].SetActive(false);
        falas[6].SetActive(false);
        falas[7].SetActive(true);
        falas[8].SetActive(true);




    }
    public void fala41()
    {
        if (inv.i71 || inv.i72 || inv.i73 || inv.i74 == true)
        {
            cond++;




            pergunta[4].SetActive(false);
            falas[7].SetActive(false);
            falas[8].SetActive(false);
        }
        if (cond >= 3)
        {
            venceu = true;

        }
        if (cond <= 2)
        {
            perdeu = true;

        }



    }
    public void fala42()
    {
        pergunta[4].SetActive(false);

        falas[7].SetActive(false);
        falas[8].SetActive(false);
        if (cond >= 3)
        {
            venceu = true;

        }
        if (cond <= 2)
        {
            perdeu = true;

        }



    }

    public void Recomeçar()
    {
        unfade.SetActive(true);
        Invoke("Recomec", 0.4f);


    }
    public void sair()
    {

        proxNv.SetActive(false);   

    }
    public void Jogar()
    {
        unfade.SetActive(true);
        Invoke("Mapa03", 0.4f);


    }
    public void proximoNivel()
    {
        
        proxNv.SetActive(true) ;


    }
    void Recomec()
    {
        SceneManager.LoadScene("Mapa2");

    }
    public void selecaoDeNiveis()
    {
        unfade.SetActive(true);
        Invoke("SelecNiveis", 0.4f);

    }
    public void Mapa03()
    {
        SceneManager.LoadScene("Mapa03");


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
        vida = cond * 25;
        if (vida >= vidaMinima && vida <= vidaMaxima)
        {
            healthBarFill.fillAmount = vida / 100;


        }
        if (venceu == true)
        {
            menuVenceu.SetActive(true);
            GlobalVariaveis.n3 = 1;


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
