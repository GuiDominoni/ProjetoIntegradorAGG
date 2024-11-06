using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System.IO;

public class Andares : MonoBehaviour
{
    public UnityEvent ToNo1, ToNo2, ToNo3, ToNo4, Sair;
    private Transform player;
    public Transform[] Andar;
    bool ativei, podeDesativarFala;
    public GameObject[] luzes;
    public TMP_Text falaTxT;
    public GameObject TextoQueApareceNaTela;    
    TelefoneFase3 telef;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        GlobalVariaveis.emQueNivelEstou = 3;
        Interações.EmQualAndarEstouFase3 = 1;
        telef = FindObjectOfType<TelefoneFase3>();
    }

    // Update is called once per frame
    void Update()
    {
        if(podeDesativarFala && Input.GetMouseButtonDown(0))
        {
            desatFala();
            podeDesativarFala = false;
            Cursor.visible = false  ;

        }
       
        if (Interações.EmQualAndarEstouFase3 == 3 && !ativei)
        {
           
            
                ativei = true;

            StartCoroutine(Escurecer());
            


        }
       
    }
    public void desatFala()
    {

        TextoQueApareceNaTela.SetActive(false);

    }
    public void Interact()
    {
               
        if(Interações.EmQualAndarEstouFase3 == 1)
        {
            
            ToNo1.Invoke();

        }
        if (Interações.EmQualAndarEstouFase3 == 2)
        {

            ToNo2.Invoke();

        }
        if (Interações.EmQualAndarEstouFase3 == 3)
        {

            ToNo3.Invoke();

        }
        if (Interações.EmQualAndarEstouFase3 == 4)
        {

            ToNo4.Invoke();

        }
      
        Cursor.visible = true;
    }
    public void IrPara1()
    {
        player.transform.position = Andar[0].transform.position;
        Time.timeScale = 1.0f;
        Interações.EmQualAndarEstouFase3 = 1;
        Cursor.visible = false;
    }
    public void IrPara2()
    {
        player.transform.position = Andar[1].transform.position;
        Time.timeScale = 1.0f;
        Interações.EmQualAndarEstouFase3 = 2;
        Cursor.visible = false;
    }
    public void IrPara3()
    {

        player.transform.position = Andar[2].transform.position;
        Time.timeScale = 1.0f;
        Interações.EmQualAndarEstouFase3 = 3;
        Cursor.visible = false;
    }
    public void IrPara4()
    {

        player.transform.position = Andar[3].transform.position;
        Time.timeScale = 1.0f;
        Interações.EmQualAndarEstouFase3 = 4;
        Cursor.visible = false;
    }
    public void sair()
    {
       Sair.Invoke();
        Time.timeScale = 1.0f;
        Cursor.visible = false;
    }
    IEnumerator Escurecer()
    {
        yield return new WaitForSeconds(15);

        for (int i = 0; i < luzes.Length; i++)
        {
            luzes[i].SetActive(true);
            StartCoroutine(comecarFala());
        }
        telef.podeLigar = true;
    }
    IEnumerator comecarFala()
    {
        yield return new WaitForSeconds(3);
        TextoQueApareceNaTela.SetActive(true);
        Cursor.visible = true;
        podeDesativarFala = true;
    }
}
