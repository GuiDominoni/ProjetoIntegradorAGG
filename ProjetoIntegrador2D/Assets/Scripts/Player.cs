using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    float horizontal, vertical;
    public float velocidade, forcaDoPulo;
    Rigidbody2D rb;
    public bool olhandoDireita;


    // Start is called before the first frame update
    void Start()
    {
        olhandoDireita = true;  
        rb = GetComponent<Rigidbody2D>();
        forcaDoPulo = 3;
    }

    // Update is called once per frame
    void Update()
    {
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