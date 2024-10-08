using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fase1 : MonoBehaviour
{
    public GameObject desaparecer, aparecer; 
    // Start is called before the first frame update
    void Start()
    {
        inv.lugar = 1;
      

    }

    // Update is called once per frame
    void Update()
    {
       
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
