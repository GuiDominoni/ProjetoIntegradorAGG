
using UnityEngine;

public class BarbeariaManager : MonoBehaviour
{
    public int emQualEsta;
    public GameObject[] Visuais;
    Player player;
    Barbeiro barbeiro;
    public GameObject tileX, tileY;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        barbeiro = FindObjectOfType<Barbeiro>();    
        emQualEsta = 0; 
    }

    // Update is called once per frame
    void Update()
    {
          


    }
    public void BarbeariaMudar(bool aumentar)
    {
        switch(aumentar)
        {
            case true:
                Visuais[emQualEsta].SetActive(false);
                if (emQualEsta == 2)
                    emQualEsta = 0;
                else emQualEsta++;

                break;
            case false:
                Visuais[emQualEsta].SetActive(false);
                if (emQualEsta == 0)
                    emQualEsta = 2;
                else emQualEsta--;  
                break;
        }
        Visuais[emQualEsta].SetActive(true);

    }
    public void Sair()
    {
        barbeiro.Interact();


    }
    public void Selecionar()
    {
        if (player.livros >= 4)
        {
            player.qualAnimator = emQualEsta + 1;
            player.livros = 0;
            barbeiro.Interact();
        }
    }
    public void InverterEscala()
    {
        tileX.transform.localScale = new Vector3(tileX.transform.localScale.x * -1, tileX.transform.localScale.y, tileX.transform.localScale.z);
        tileY.transform.localScale = new Vector3(tileY.transform.localScale.x, tileY.transform.localScale.y * -1, tileY.transform.localScale.z);
    }

}
