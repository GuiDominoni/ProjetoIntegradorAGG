using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 60;
    public Text texto;
    public GameObject cinza, itens;
    public Image inventario;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("timerMenos", 1, 1);
  
    }

    // Update is called once per frame
    void Update()
    {
        



        texto.text = timer.ToString();
     
         if(timer <= 0 || inv.lugar == 5)
         {
            cinza.SetActive(true);
            novaPos();  
            cancelInvoke();
                
            
         }

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
}
