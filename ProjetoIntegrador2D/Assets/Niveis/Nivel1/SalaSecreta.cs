using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalaSecreta : MonoBehaviour
{
    public Transform X, MaxY, MinY;
    GameObject Player;
    public GameObject TilemapUwU;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        TilemapUwU.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if(Player.transform.position.x > X.position.x && Player.transform.position.y > MinY.position.y && Player.transform.position.y < MaxY.position.y) 
        {
            TilemapUwU.SetActive(false);


        }else
        {
            TilemapUwU.SetActive(true);

        }



    }
}
