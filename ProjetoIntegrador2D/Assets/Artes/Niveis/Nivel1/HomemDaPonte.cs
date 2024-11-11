using TMPro;
using UnityEngine;
using UnityEngine.Events;



public class HomemDaPonte : MonoBehaviour
{
    public GameObject[] item5;
    public GameObject interactionPrompt, item, colisor, Inventario;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    public int Ordem, OP, madeirasQFalta, a;
    public string aviso1, aviso2;
    public UnityEvent Fala1, Fala2, desativ1, desativ2, ativarPonte;
    public TMP_Text texto1, texto11, texto2;

    private void Start()
    {
        GlobalVariaveis.emQueNivelEstou = 1;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        interactionPrompt.SetActive(false);
        madeirasQFalta = 4;
    }

    void Update()
    {
        texto2.text = MadeirasQueEuTenho.Madeiras.ToString() + "x";
        if (Ordem <= 2 && Ordem != 0)  
                texto11.text = "Eu ainda preciso de " + madeirasQFalta.ToString() + " madeiras para poder construir a ponte"; 
        if (Ordem >= 3) 
                texto11.text = "Valeu cara"; 
       /* if (MadeirasQueEuTenho.possoPegar == true)
        {
            Inventario.SetActive(true);


        }
        if (!MadeirasQueEuTenho.possoPegar)  
                Inventario.SetActive(false); 
        Inventario.SetActive(MadeirasQueEuTenho.possoPegar ? true : false); 
       */
       

        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= interactionRange && Ordem != 3 && a == 0)
        {
            interactionPrompt.SetActive(true);
            interactionPrompt.transform.position = transform.position + new Vector3(0, 2.6f, 0); 

            if (Input.GetKeyDown(interactionKey))
            {
                Interact();
            }
        }
        else
        {
            interactionPrompt.SetActive(false);
        }
        if (madeirasQFalta <= 0)
        {

            ativarPonte.Invoke();
            Destroy(colisor);
            Ordem++;
            a++;
            MadeirasQueEuTenho.possoPegar = false;
        }
    }


    public void Interact()
    {
        if (Ordem == 0)
        {
            Fala1.Invoke();

        }
        else if (Ordem == 1)
        {
            MadeirasQueEuTenho.possoPegar = true;
            Fala2.Invoke();
            if (OP == 1)
            {
                madeirasQFalta -= MadeirasQueEuTenho.Madeiras;
                MadeirasQueEuTenho.Madeiras = 0;

            }


        }
        Cursor.visible = true;

    }
    public void vouTeAjudar()
    {
        Ordem++;
        desativ1.Invoke();
        OP = 1;
        MadeirasQueEuTenho.possoPegar = true;
        Cursor.visible = false;
    }
    public void tchau1()
    {
        desativ1.Invoke();
        Cursor.visible = false;

    }
    public void tchau2()
    {
        desativ2.Invoke();

        Cursor.visible = false;
    }

}
public static class MadeirasQueEuTenho
{

    public static int Madeiras;
    public static bool possoPegar;

}