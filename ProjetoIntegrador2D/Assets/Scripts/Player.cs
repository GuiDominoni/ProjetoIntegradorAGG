using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{


    public float horizontal, vertical, velocidade;
    Rigidbody2D rb;
    public bool olhandoDireita;
    public GameObject preto, cinza;



    // Start is called before the first frame update
    void Start()
    {
        olhandoDireita = true;  
        rb = GetComponent<Rigidbody2D>();
        velocidade = 5; 
    }

    // Update is called once per frame
    void Update()
    {
        if (preto.activeSelf || cinza.activeSelf)
        {
            velocidade = 0;


        }
        else {

                velocidade = 5;


        }
        movimento();
        Flip();
       

    }

    
        void movimento()
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");

           
            Vector2 movimento = new Vector2(horizontal, vertical).normalized;

            
            rb.velocity = movimento * velocidade;
         
        }
    

    
    void Flip()
    {
        if(horizontal > 0 && !olhandoDireita || horizontal < 0 && olhandoDireita)
        {
            olhandoDireita = !olhandoDireita;
            Vector2 localscale = transform.localScale;
            localscale.x *= -1;
            transform.localScale = localscale;
        }
        
    }

    
}
public static class Interações
{
    public static bool TenhoCartaoFase2;
    public static int EmQualAndarEstouFase3;


}



