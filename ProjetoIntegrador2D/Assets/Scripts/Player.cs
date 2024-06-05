using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{


    public float horizontal, vertical, a;
    public float velocidade;
    Rigidbody2D rb;
    public bool olhandoDireita;
    public GameObject awsd;


    // Start is called before the first frame update
    void Start()
    {
        olhandoDireita = true;  
        rb = GetComponent<Rigidbody2D>();
       
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
    void AWSD()
    {
        awsd.SetActive(true);


    }
    void FAWSD()
    {
        awsd.SetActive(false);

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

    public void OnTriggerEnter2D(Collider2D other)
    {
        int caso = 1;
        if(caso == 1 && other.gameObject.CompareTag("AWSD"))
        {
            Invoke("AWSD", 2f);
            if(horizontal != 0 || vertical != 0 )
            {
                Invoke("FAWSD", 1.5f);

            }
            caso += 1;
            a = caso;

            


        }



    }
}