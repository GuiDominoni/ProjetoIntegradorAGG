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
    Animator anim;
   public RuntimeAnimatorController[] controller;
    public int qualAnimator;


    // Start is called before the first frame update
    void Start()
    {   
        anim = GetComponent<Animator>();    
        olhandoDireita = false;  
        rb = GetComponent<Rigidbody2D>();
        velocidade = 5;
        Interações.TenhoCartaoFase2 = false;
        Interações.MudouDePosição = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        anim.runtimeAnimatorController = controller[qualAnimator];
        anim.SetFloat("MovX", rb.velocity.x);
        anim.SetFloat("MovY", rb.velocity.y);
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
    public static bool isFreezing;
    public static bool TenhoCartaoFase2;
    public static int EmQualAndarEstouFase3;
    public static bool MudouDePosição;

}



