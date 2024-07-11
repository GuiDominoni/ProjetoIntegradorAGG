using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TodosMenus : MonoBehaviour
{
    public GameObject menu;
    int num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape) && num == 0)
        {
            
            menu.SetActive(true);
            num++;


        }
        if (Input.GetKeyUp(KeyCode.Escape) && num == 1)
        {

            menu.SetActive(false);
            num--;


        }





    }
    public void Continuar()
    {
        menu.SetActive(false);
        num--;  

    }
    public void Sair()
    {
        SceneManager.LoadScene("SelecaoNiveis");


    }
}
