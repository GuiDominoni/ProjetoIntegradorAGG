using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void Jogar()
    {
       

    }
    public void Opcoes()
    {


    }
    public void Creditos() {

        SceneManager.LoadScene("Creditos");
         

    }
    public void Sair()
    {
        Application.Quit();
            
    }

    
}
