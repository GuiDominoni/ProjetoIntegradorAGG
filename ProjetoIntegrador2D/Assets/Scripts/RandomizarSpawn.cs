using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizarSpawn : MonoBehaviour
{
    public GameObject[] itens, spawn;
    // Start is called before the first frame update
    void Start()
    {
        int QualVaiSer = 0;
        for (int x = 0; x < itens.Length; x++)
        {
            int RandomNumero1 = Random.Range(0, 15);


            if (itens[QualVaiSer] != null && spawn[RandomNumero1] != null) { itens[QualVaiSer].transform.position = spawn[RandomNumero1].transform.position; }
            
            if(spawn[RandomNumero1] = null)
            {
                while (spawn[RandomNumero1] != null)
                {
                    RandomNumero1 = Random.Range(0, 15);
                    itens[QualVaiSer].transform.position = spawn[RandomNumero1].transform.position;


                }



            }
            QualVaiSer++;
        }





    }

    // Update is called once per frame
    void Update()
    {
        

    }
}