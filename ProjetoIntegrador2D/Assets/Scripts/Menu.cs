using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject opcoes;
    public GameObject preto;

    public void Jogar()
    {

        preto.SetActive(true);

        Invoke("Cut", 0.50f);

    }
    public void Opcoes()
    {

        opcoes.SetActive(true);

    }
    public void Creditos()
    {

        SceneManager.LoadScene("Creditos");


    }
    public void Sair()
    {
        Application.Quit();

    }
    public void Cut()
    {

        SceneManager.LoadScene("Cutscene");

    }

}