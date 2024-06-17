using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fase1 : MonoBehaviour
{
    public GameObject tribunal, desaparecer, aparecer; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Inv.lugar == 5)
        {
            tribunal.SetActive(true);

        }
        Invoke("unfad", 1);
    }
    public void irTrib()
    {
        aparecer.SetActive(true);
        Invoke("trib", 1);


    }
     void trib()
    {

        SceneManager.LoadScene("Tribunal");
    }
    void unfad()
    {

        desaparecer.SetActive(false);

    }
}
