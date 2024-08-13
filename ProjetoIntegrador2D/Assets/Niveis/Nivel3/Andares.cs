using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using static UnityEditor.Progress;

public class Andares : MonoBehaviour
{
    public UnityEvent ToNo1, ToNo2, ToNo3, ToNo4, Sair;
   public GameObject interactionPrompt, item;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    public Transform[] Andar;
    
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
}
