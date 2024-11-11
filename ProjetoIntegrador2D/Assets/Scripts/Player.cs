using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{


    public float horizontal, vertical, velocidade;
    Rigidbody2D rb;
    public bool olhandoDireita;
    public GameObject preto, cinza;
    Animator anim;
    public RuntimeAnimatorController[] controller;
    public int qualAnimator;
    Andares andares;
    public int livros;
    public TMP_Text livrosFase4Txt;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        andares = FindObjectOfType<Andares>();
        olhandoDireita = false;
        rb = GetComponent<Rigidbody2D>();
        velocidade = 5;
        Interações.TenhoCartaoFase2 = false;
        Interações.MudouDePosição = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(livrosFase4Txt != null)
        {
            livrosFase4Txt.text = "Livros: " + livros;


        }
        anim.runtimeAnimatorController = controller[qualAnimator];
        anim.SetFloat("MovX", rb.velocity.x);
        anim.SetFloat("MovY", rb.velocity.y);
       
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
        if (horizontal > 0 && !olhandoDireita || horizontal < 0 && olhandoDireita)
        {
            olhandoDireita = !olhandoDireita;
            Vector2 localscale = transform.localScale;
            localscale.x *= -1;
            transform.localScale = localscale;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coisas"))
        {
            andares.Interact();


        }    
    
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coisas"))
        {
            andares.sair();


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



