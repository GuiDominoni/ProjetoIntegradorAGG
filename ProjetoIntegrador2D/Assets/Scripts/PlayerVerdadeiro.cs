using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerVerdadeiro : MonoBehaviour
{


    public float horizontal, vertical, a;
    public float velocidade;
    Rigidbody2D rb;
    public bool olhandoDireita;
    private Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        olhandoDireita = true;
        rb = GetComponent<Rigidbody2D>();
        velocidade = 5;
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        movimento();
        Flip();
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetInteger("Bora", 1);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetInteger("Bora", 0);

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
        if (horizontal > 0 && !olhandoDireita || horizontal < 0 && olhandoDireita)
        {
            olhandoDireita = !olhandoDireita;
            Vector2 localscale = transform.localScale;
            localscale.x *= -1;
            transform.localScale = localscale;
        }

    }


}