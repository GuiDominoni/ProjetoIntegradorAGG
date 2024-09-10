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
   public GameObject interactionPrompt, item;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f,timerContagem;
    private Transform player;
    public Transform[] Andar;
    bool ativei;
    public GameObject[] luzes;
    public int QualFala;
    public TMP_Text falaTxT;
    public GameObject TextoQueApareceNaTela;
    // Start is called before the first frame update
    void Start()
    {
        Interações.EmQualAndarEstouFase3 = 1;

        player = GameObject.FindGameObjectWithTag("Player").transform;
        interactionPrompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(QualFala == 1)
        {
           
            falaTxT.text = "A luz caiu, eu preciso achar um jeito de sair dessa situação";
           StartCoroutine(comecarFala());

        }
        else if(QualFala != 1) 
        {
            TextoQueApareceNaTela.SetActive(false);


        }
        if (Interações.EmQualAndarEstouFase3 == 3 && !ativei)
        {
            bool timer =false;
            timerContagem = timerContagem + Time.deltaTime;

            if (timerContagem > 10 && timer == false)
            {
                ativei = true;
                timer = true;
                for (int i = 0; i < luzes.Length; i++)
                {
                    luzes[i].SetActive(true);
                    QualFala = 1;
                }
            }


        }
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= interactionRange)
        {
            interactionPrompt.SetActive(true);
            interactionPrompt.transform.position = transform.position + new Vector3(0, 1.5f, 0); // Posiciona o texto acima do objeto

            if (Input.GetKeyDown(interactionKey))
            {
                Interact();
            }
        }
        else
        {
            interactionPrompt.SetActive(false);
        }
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
        Time.timeScale = 0.0f;
    }
    public void IrPara1()
    {
        player.transform.position = Andar[0].transform.position;
        Time.timeScale = 1.0f;
        Interações.EmQualAndarEstouFase3 = 1;
    }
    public void IrPara2()
    {
        player.transform.position = Andar[1].transform.position;
        Time.timeScale = 1.0f;
        Interações.EmQualAndarEstouFase3 = 2;
    }
    public void IrPara3()
    {

        player.transform.position = Andar[2].transform.position;
        Time.timeScale = 1.0f;
        Interações.EmQualAndarEstouFase3 = 3;
    }
    public void IrPara4()
    {

        player.transform.position = Andar[3].transform.position;
        Time.timeScale = 1.0f;
        Interações.EmQualAndarEstouFase3 = 4;
    }
    public void sair()
    {
       Sair.Invoke();
        Time.timeScale = 1.0f;

    }
    public void sairDaFala()
    {

        QualFala = 0;   

    }
    IEnumerator comecarFala()
    {
        yield return new WaitForSeconds(3);
        TextoQueApareceNaTela.SetActive(true);


    }
}
