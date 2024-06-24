using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tribunal : MonoBehaviour
{
    public GameObject[] falas, pergunta;
    public bool venceu, perdeu;
    public GameObject menuVenceu, menuPerdeu, unfade, fade; 
    public void fala11()
    {
        pergunta[1].SetActive(false);
        falas[1].SetActive(false);
        falas[2].SetActive(false);
        falas[3].SetActive(true);
        falas[4].SetActive(true);
        pergunta[2].SetActive(true);

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
        pergunta[2].SetActive(false);
        pergunta[3].SetActive(true);
        falas[3].SetActive(false);
        falas[4].SetActive(false);
        falas[5].SetActive(true);
        falas[6].SetActive(true);




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
        pergunta[3].SetActive(false);
        pergunta[4].SetActive(true);
        falas[5].SetActive(false);
        falas[6].SetActive(false);
        falas[7].SetActive(true);
        falas[8].SetActive(true);




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
       


    }
    public void fala42()
    {
        pergunta[4].SetActive(false);
      
        falas[7].SetActive(false);
        falas[8].SetActive(false);
        


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

    }

}
