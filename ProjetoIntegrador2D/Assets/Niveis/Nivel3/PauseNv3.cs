using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseNv3 : MonoBehaviour
{
    public float timer = 60;
    public Text texto;
    public GameObject preto, pause, aviso;
    public Image inventario;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("timerMenos", 1, 1);
        inv.lugar = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Escape))
        {

            pause.SetActive(true);
            cancelInvoke();
           

        }


        texto.text = timer.ToString();

        if (inv.lugar == 5)
        {

            Invoke("irTrib", 3f);
            cancelInvoke();
            novaPos();
            aviso.SetActive(true);
        }
        if (timer <= 0)
        {
            irTrib();


        }
    }
    public void continuar()
    {
        pause.SetActive(false);
        InvokeRepeating("timerMenos", 0, 1);


    }
    public void sair()
    {
        preto.SetActive(true);
        Invoke("carregarNiveis", 0.4f);

    }
    public void timerMenos()
    {
        timer -= 1;


    }
    public void cancelInvoke()
    {

        CancelInvoke("timerMenos");
    }
    public void novaPos()
    {
        if (inventario != null)
        {
            RectTransform rectTransform = inventario.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2(0f, 0f);
        }

    }
    public void carregarNiveis()
    {


        SceneManager.LoadScene("SelecaoNiveis");
    }
    public void irTrib()
    {
        preto.SetActive(true);
        Invoke("trib", 0.4f);


    }
    public void trib()
    {

        SceneManager.LoadScene("Tribunal03");

    }

}
