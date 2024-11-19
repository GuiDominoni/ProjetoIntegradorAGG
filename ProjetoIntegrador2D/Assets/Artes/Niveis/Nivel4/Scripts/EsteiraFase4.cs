using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EsteiraFase4 : MonoBehaviour
{

   
    Player player;
    public int x, y;
    bool aplicandoForca;
    Vector2 forca = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        x *= 130;
        y *= 130;

    }

    // Update is called once per frame
    void Update()
    {
      player.rb.AddForce(forca);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            forca = new Vector2(x, y);

        }
                    
    }   
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            forca = new Vector2(0, 0);

        }
       
    }
    public void InverterVelo()
    {
        x *= -1;
        y *= -1;
        

    }

}
