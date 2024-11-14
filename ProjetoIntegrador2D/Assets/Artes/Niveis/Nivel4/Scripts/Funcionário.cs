using System.Collections;
using UnityEngine;

public class Funcionário : MonoBehaviour
{
    public GameObject interactionPrompt, falaNaoPermitida, falaPermitida;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    public bool podeMover;
    Player scriptPlayer;
    public Transform[] pontos;
    public int i;
    Animator anim;
    SpriteRenderer spriteRenderer;  

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        scriptPlayer = FindObjectOfType<Player>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        interactionPrompt.SetActive(false);
    }

    void Update()

    {
        if (i == 1)
        {
            spriteRenderer.flipX = false;
        }
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= interactionRange && inv.possoPegarOItem)
        {
            interactionPrompt.SetActive(true);
            interactionPrompt.transform.position = transform.position + new Vector3(0, 1.5f, 0); 

            if (Input.GetKeyDown(interactionKey))
            {
                Interact();
            }
        }
        else
        {
            interactionPrompt.SetActive(false);
        }
        Mover();
    }
    
    public void Interact()
    {
      
        if (scriptPlayer.qualAnimator != 2)
            falaNaoPermitida.SetActive(true);
        else { podeMover = true; falaPermitida.SetActive(true); }

    }
    public void Mover()
    {
        if (podeMover)
        {
            print(Vector3.Distance(transform.position, pontos[i].position));
                anim.SetBool("Andando", true);
          
            
            transform.position = Vector2.MoveTowards(transform.position, pontos[i].position, 4f * Time.deltaTime);



            if (Vector3.Distance(transform.position, pontos[i].position) < 0.85f)
            {

                i++;
                anim.SetBool("Andando", true);

            }


        }
    }
}
