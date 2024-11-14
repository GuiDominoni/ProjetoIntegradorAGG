
using UnityEngine;

public class ArrumarOPoste : MonoBehaviour
{

    SpriteRenderer SpriteRenderer;
    Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        Player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.position.y >  transform.position.y - 1.8f) 
        { 
            SpriteRenderer.sortingOrder = 12;
        
        
        }else
        {
            SpriteRenderer.sortingOrder = 10;


        }
    }
}
