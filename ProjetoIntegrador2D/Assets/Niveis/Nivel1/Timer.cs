using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 60;
    public Text texto;
    public GameObject preto, avisoTuto,botaoProximo, tutoQueNojo;
    public Image inventario;
    public GameObject aviso;
    public UnityEvent OnPause, OnUnPause;
    public GameObject[] verdes;




    // Start is called before the first frame update
    void Start()
    {
        if(GlobalVariaveis.emQueNivelEstou == 1)
        {

            Time.timeScale = 0;

        }
        
        zerarStatico();


    }


    // Update is called once per frame
    void Update()
    {
        QueRaiva();
            int TimerVerdadeiro;
            TimerVerdadeiro = Mathf.RoundToInt(timer);

            texto.text = TimerVerdadeiro.ToString();
            Invoke("timerMenos", 0);
        
        

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




        if (inv.lugar == 5)
        {
            cancelInvoke();
            novaPos();
            Interações.MudouDePosição = true;
            avisoTuto.SetActive(true);
            botaoProximo.SetActive(true);
        }
        if (timer <= 0)
        {
            irTrib();


        }

    }
   
    public void jogar()
    {
        tutoQueNojo.SetActive(false);
        Time.timeScale = 1;

    }
    public void continuar()
    {
        OnUnPause.Invoke();
        Time.timeScale = 1;


    }
    public void sair()
    {
        preto.SetActive(true);
        SceneManager.LoadScene("SelecaoNiveis");
        Time.timeScale = 1; 
    }
    public void timerMenos()
    {
        timer -= Time.deltaTime;


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
    public void trib()
    {

        SceneManager.LoadScene("TribunalV");
        Debug.Log("AINDA NAO FIZ ME AVISA SE LER ISSO");
    }
    void QueRaiva()
    {
        if (Interações.MudouDePosição)
        {
            if (inv.i11)
            {
                verdes[1].SetActive(true);


            }
            if (inv.i12)
            {
                verdes[2].SetActive(true);


            }
            if (inv.i13)
            {
                verdes[3].SetActive(true);


            }
            if (inv.i14)
            {

                verdes[4].SetActive(true);

            }
            if (inv.i71)
            {
                verdes[1].SetActive(true);


            }
            if (inv.i72)
            {
                verdes[2].SetActive(true);


            }
            if (inv.i73)
            {
                verdes[3].SetActive(true);


            }
            if (inv.i74)
            {

                verdes[4].SetActive(true);

            }
            if (inv.i61)
            {
                verdes[1].SetActive(true);


            }
            if (inv.i62)
            {
                verdes[2].SetActive(true);


            }
            if (inv.i63)
            {
                verdes[3].SetActive(true);


            }
            if (inv.i64)
            {

                verdes[4].SetActive(true);

            }
            if (inv.i41)
            {
                verdes[1].SetActive(true);


            }
            if (inv.i42)
            {
                verdes[2].SetActive(true);


            }
            if (inv.i43)
            {
                verdes[3].SetActive(true);


            }
            if (inv.i44)
            {

                verdes[4].SetActive(true);

            }
        }

    }
    void zerarStatico()
    {

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
        inv.i81 = false;
        inv.i82 = false;
        inv.i83 = false;
        inv.i84 = false;
        inv.i91 = false;
        inv.i92 = false;
        inv.i93 = false;
        inv.i94 = false;
        inv.i101 = false;
        inv.i102 = false;
        inv.i103 = false;
        inv.i104 = false;
        inv.i104 = false;

    }
}
