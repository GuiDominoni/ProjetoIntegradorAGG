using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    public GameObject preto;
    public float horizontal, vertical, a;
    public float velocidade;
    Rigidbody2D rb;
    public bool olhandoDireita;
    Animator anim;

  


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        olhandoDireita = true;  
        rb = GetComponent<Rigidbody2D>();
        velocidade = 5; 
    }

    // Update is called once per frame
    void Update()
    {
        
        movimento();
      
        if( vertical < 0)
        {
            anim.SetInteger("Transicao", 1);


        }
        if (vertical > 0)
        {
            anim.SetInteger("Transicao", 2);


        }
        if (horizontal < 0)
        {
            anim.SetInteger("Transicao", 4);


        }
        if (horizontal == 0 && vertical == 0 )
        {

            anim.SetInteger("Transicao", 0);

        }
        if (horizontal > 0)
        {
            anim.SetInteger("Transicao", 3);


        }


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