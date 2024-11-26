
using UnityEngine;

public class LanternaFase3 : MonoBehaviour
{

    public GameObject interactionPrompt;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 2.0f;
    private Transform player;
    public GameObject luzLanterna, lantenaDesativar, luzGlobal;
    public GameObject[] spawns;

    private void Start()
    {
        int random = Random.Range(0, spawns.Length);
        transform.position = spawns[random].transform.position;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        interactionPrompt.SetActive(false);
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= interactionRange)
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

    }

    public void Interact()
    {
        luzLanterna.SetActive(true);
        lantenaDesativar.SetActive(false);
        Destroy(gameObject);
    }

}

