using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TribunalNv2 : MonoBehaviour
{
    public GameObject[] falas;
    public bool venceu, perdeu;
    public GameObject menuVenceu, menuPerdeu, unfade, fade;
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
    public void fala51()
    {
        falas[9].SetActive(false);
        falas[10].SetActive(false);
       


    }
    public void fala52()
    {

        falas[9].SetActive(false);
        falas[10].SetActive(false);
    



    }
    public void Recomeçar()
    {
        unfade.SetActive(true);
        Invoke("Recomec", 0.4f);


    }
    public void proximoNivel()
    {
        unfade.SetActive(true);
        Invoke("Mapa03", 0.4f);



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

    }

}
