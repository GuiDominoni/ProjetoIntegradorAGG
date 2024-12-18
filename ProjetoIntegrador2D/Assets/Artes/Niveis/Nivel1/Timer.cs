using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timer;
    public Text texto;
    public GameObject avisoTuto,botaoProximo, tutoQueNojo, PretoTelas, pretoAndares;
    public Image inventario;
    public UnityEvent OnPause, OnUnPause, opcoes, sairOpcoes;
    public GameObject[] verdes;
    bool pareiOTimer;
    float timer2;



    // Start is called before the first frame update
    void Start()
    {
        inv.lugar = 1;
        timer = 600;
        
       
       zerarStatico();
       
    }


    // Update is called once per frame
    void Update()
    {
        int timerArredondado;
        timerArredondado = Mathf.RoundToInt(timer);
        
        timer2 += Time.deltaTime;
        if(timer2 >= 4)
        {
            VerdeStatico();
            timer2 = 0;

        }
        timer -= Time.deltaTime;
            texto.text = timerArredondado.ToString();
        if (GlobalVariaveis.emQueNivelEstou != 3)
        {
            if (Input.GetButtonDown("Cancel") && !PretoTelas.activeSelf)
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
        }
        else
        {
            if (Input.GetButtonDown("Cancel") && !PretoTelas.activeSelf && !pretoAndares.activeSelf )
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
        }
        




        if (inv.lugar == 5)
        {
            novaPos();
            Interações.MudouDePosição = true;
            if (GlobalVariaveis.emQueNivelEstou == 1)
            {
                avisoTuto.SetActive(true);
            }
            botaoProximo.SetActive(true);
          
        }
        if (timer <= 0)
        {
            trib();


        }

    }
     public void opcoesEntrar()
     {
        opcoes.Invoke();


     }
    public void opcoesSair()
    {

        sairOpcoes.Invoke();

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
        SceneManager.LoadScene("SelecaoNiveis");
        Time.timeScale = 1; 
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
   
    public void trib()
    {
        switch (GlobalVariaveis.emQueNivelEstou)
        {
            case 1:
                SceneManager.LoadScene("TribunalV");
                break;
            case 2:
                SceneManager.LoadScene("TribunalV2");
                break;
            case 3:
                SceneManager.LoadScene("TribunalV3");
                break;
            case 4:
                SceneManager.LoadScene("TribunalV4");
                break;

        } 
    }
    void VerdeStatico()
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
    IEnumerator TimerDiminuir()
    {
        yield return new WaitForSeconds(1);
        timer--;
        if (!pareiOTimer)
              StartCoroutine(TimerDiminuir());
        


    }
}
