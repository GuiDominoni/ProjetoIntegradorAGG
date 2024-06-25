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
    public GameObject menuVenceu, menuPerdeu, unfade, fade, aviso1, aviso2;
    public int cond = 0;
    public Image healthBarFill; // Referência ao Image de preenchimento
    public float vida, vidaMaxima, vidaMinima;
    public void fala11()
    {
        if (inv.i21 || inv.i22 || inv.i23 || inv.i24 == true)
        {
            pergunta[1].SetActive(false);
        falas[1].SetActive(false);
        falas[2].SetActive(false);
        falas[3].SetActive(true);
        falas[4].SetActive(true);
        pergunta[2].SetActive(true);
        
            cond++;

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
        if (inv.i11 || inv.i12 || inv.i13 || inv.i14 == true)
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
        if (inv.i31 || inv.i32 || inv.i33 || inv.i34 == true)
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
        

            pergunta[4].SetActive(false);
            falas[7].SetActive(false);
            falas[8].SetActive(false);
        
        if (cond >= 3)
        {
            venceu = true;

        }else if (cond >= 2)
        {
            perdeu = true;

        }


    }
    public void fala42()
    {
        if (inv.i61 || inv.i62 || inv.i63 || inv.i64 == true)
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
   
    public void Recomeçar()
    {
        unfade.SetActive(true);
        Invoke("Recomec", 0.4f);
        

    }
    public void proximoNivel()
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
