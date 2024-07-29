using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerNv2 : MonoBehaviour
{
    public float timer = 60;
    public Text texto;
    public GameObject preto;
    public Image inventario;
    public GameObject aviso;
    public UnityEvent OnPause, OnUnPause;




    // Start is called before the first frame update
    void Start()
    {
        Interações.TenhoCartaoFase2 = false;
        inv.i11 = false;
        inv.i12 = false;
        inv.i13 = false;
        inv.i14 = false;
        inv.i21 = false;
        inv.i22 = false;
        inv.i23 = false;
        inv.i24 = false;
        inv.i31 = false;
        inv.i32 = false;
        inv.i33 = false;
        inv.i34 = false;
        inv.i41 = false;
        inv.i42 = false;
        inv.i43 = false;
        inv.i44 = false;
        inv.i51 = false;
        inv.i52 = false;
        inv.i53 = false;
        inv.i54 = false;
        inv.i61 = false;
        inv.i62 = false;
        inv.i63 = false;
        inv.i64 = false;
        inv.i71 = false;
        inv.i72 = false;
        inv.i73 = false;
        inv.i74 = false;
        InvokeRepeating("timerMenos", 1, 1);
        timer = 60;

    }


    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetButtonDown("Cancel"))
        {

            if (Time.timeScale == 1)
            {
                OnPause.Invoke();
                Time.timeScale = 0;

            }
            else
            {
                OnUnPause.Invoke();
                Time.timeScale = 1;
            }


        }


        texto.text = timer.ToString();

        if (inv.lugar == 5)
        {
            aviso.SetActive(true);
            Invoke("irTrib", 4f);
            cancelInvoke();
            novaPos();

        }
        if (timer <= 0)
        {
            irTrib();


        }

    }
    public void continuar()
    {
        OnUnPause.Invoke();
        InvokeRepeating("timerMenos", 0, 1);


    }
    public void sair()
    {
        preto.SetActive(true);
        Invoke("carregarNiveis", 0.4f);
        OnUnPause.Invoke();

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
        RectTransform rectTransform = inventario.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(0f, 0f);

    }
    public void carregarNiveis()
    {


        SceneManager.LoadScene("SelecaoNiveis");
    }
    public void irTrib()
    {
        preto.SetActive(true);
        Invoke("trib", 1);


    }
    void trib()
    {

        SceneManager.LoadScene("TribunalNv2");
    }
    public void repetindo()
    {
        InvokeRepeating("timerMenos", 0, 1);

    }
}
